using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Models;
using TheGlobalPhilanthropyTracker.Repositories;

namespace TheGlobalPhilanthropyTracker.UI
{
    public partial class FinanceTab : UserControl
    {
        private FinanceRepository _financeRepo = new FinanceRepository();
        private InitiativeRepository _initiativeRepo = new InitiativeRepository();
        private SupporterRepository _supporterRepo = new SupporterRepository();
        public FinanceTab()
        {
            InitializeComponent();
        }

        private void FinanceTab_Load(object sender, EventArgs e)
        {
            LoadInitiatives();
            LoadVendors();
            LoadSupporters();
        }
        private void LoadInitiatives()
        {
            List<Initiatives> initiatives = _initiativeRepo.GetInitiatives();

            cmbInitiative.DataSource = new List<Initiatives>(initiatives);
            cmbInitiative.DisplayMember = "title";
            cmbInitiative.ValueMember = "initiativeId";
            cmbInitiative.SelectedIndex = -1;

            cmbProgressInitiative.DataSource = new List<Initiatives>(initiatives);
            cmbProgressInitiative.DisplayMember = "title";
            cmbProgressInitiative.ValueMember = "initiativeId";
            cmbProgressInitiative.SelectedIndex = -1;
        }

        private void LoadVendors()
        {
            List<Vendors> vendors = _financeRepo.GetVendors();
            cmbVendor.DataSource = vendors;
            cmbVendor.DisplayMember = "companyName";
            cmbVendor.ValueMember = "vendorId";
            cmbVendor.SelectedIndex = -1;
        }
        private void LoadSupporters()
        {
            List<Supporters> supporters = _supporterRepo.GetAllSupporters();
            cmbSupporter.DataSource = supporters;
            cmbSupporter.DisplayMember = "FirstName";
            cmbSupporter.ValueMember = "SupporterId";
            cmbSupporter.SelectedIndex = -1;
        }

        private void btnAddExpenditure_Click(object sender, EventArgs e)
        {
            //Input Validation 
            if(cmbInitiative.SelectedValue == null)
            {
                MessageBox.Show("Please select an initiative");
                return;
            }
            if (cmbVendor.SelectedValue == null) {
                MessageBox.Show("Please select a vendor");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount)) { //'amount' stores the valid decimal
                MessageBox.Show("Please enter a valid amount");
                return;
            }
            if (amount <= 0) {
                MessageBox.Show("Amount must be greater than zero");
                return;
            }


            Expenditures exp = new Expenditures();
            exp.initiativeId = (int)cmbInitiative.SelectedValue;
            exp.vendorId = (int)cmbVendor.SelectedValue;
            exp.amountSpent = amount;
            exp.dateSpent = dtpExpenditureDate.Value;

            _financeRepo.AddExpenditure(exp);
            MessageBox.Show("Expenditure added successfully!");

            txtAmount.Clear();
            cmbInitiative.SelectedIndex = -1;
            cmbVendor.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            cmbInitiative.SelectedIndex = -1;
            cmbVendor.SelectedIndex = -1;
        }

        private void btnCheckProgress_Click(object sender, EventArgs e)
        {
            if (cmbProgressInitiative.SelectedValue == null)
            {
                MessageBox.Show("Please select an initiative.");
                return;
            }

            int initiativeId = Convert.ToInt32(cmbProgressInitiative.SelectedValue);
            decimal progress = _financeRepo.GetInitiativeProgress(initiativeId);

            int roundedProgress = (int)Math.Round(progress, MidpointRounding.AwayFromZero); //rounding properly
            int clampedProgress = Math.Max(progressBarFunding.Minimum, Math.Min(roundedProgress, progressBarFunding.Maximum));//0 ~ roundedProgress or 100 
           
            progressBarFunding.Value = clampedProgress;
            lblProgressPercent.Text = $"{clampedProgress}% funded";
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (cmbSupporter.SelectedValue == null)
            {
                MessageBox.Show("Please select a Supporter.");
                return;
            }
            int supporterId = Convert.ToInt32(cmbSupporter.SelectedValue);
            DataTable contributions = _financeRepo.GetSupporterContributions(supporterId);
            dgvContributions.DataSource = contributions;
        }

        
    }
}
