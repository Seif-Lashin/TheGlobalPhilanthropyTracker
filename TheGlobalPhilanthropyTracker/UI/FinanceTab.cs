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
        private FinanceRepository _repo = new FinanceRepository();
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
            DataTable dt = _repo.GetInitiatives();
            cmbInitiative.DataSource = dt;
            cmbInitiative.DisplayMember = "TITLE";
            cmbInitiative.ValueMember = "INITIATIVEID";
            cmbInitiative.SelectedIndex = -1;

            DataTable dt2 = _repo.GetInitiatives();
            cmbProgressInitiative.DataSource = dt2;
            cmbProgressInitiative.DisplayMember = "TITLE";
            cmbProgressInitiative.ValueMember = "INITIATIVEID";
            cmbProgressInitiative.SelectedIndex = -1;
        }

        private void LoadVendors()
        {
            DataTable dt = _repo.GetVendors();
            cmbVendor.DataSource = dt;
            cmbVendor.DisplayMember = "COMPANY_NAME";
            cmbVendor.ValueMember = "VENDORID";
            cmbVendor.SelectedIndex = -1;
        }
        private void LoadSupporters()
        {
            DataTable dt = _repo.GetSupporters();
            cmbSupporter.DataSource = dt;
            cmbSupporter.DisplayMember = "FULLNAME";
            cmbSupporter.ValueMember = "SUPPORTERID";
            cmbSupporter.SelectedIndex = -1;
        }

        private void btnAddExpenditure_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an amount");
                return;
            }

            Expenditures exp = new Expenditures();
            exp.initiativeId = (int)cmbInitiative.SelectedValue;
            exp.vendorId = (int)cmbVendor.SelectedValue;
            exp.amountSpent = decimal.Parse(txtAmount.Text);
            exp.dateSpent = dtpExpenditureDate.Value;

            _repo.AddExpenditure(exp);
            MessageBox.Show("Expenditure added successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            cmbInitiative.SelectedIndex = -1;
            cmbVendor.SelectedIndex = -1;
        }

        private void ExpTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckProgress_Click(object sender, EventArgs e)
        {
            if (cmbProgressInitiative.SelectedValue == null)
            {
                MessageBox.Show("Please select an initiative.");
                return;
            }

            int initiativeId = Convert.ToInt32(cmbProgressInitiative.SelectedValue);
            decimal progress = _repo.GetInitiativeProgress(initiativeId);

            progressBarFunding.Value = (int)Math.Min(progress, 100);
            lblProgressPercent.Text = $"{progress}% funded";
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (cmbSupporter.SelectedValue == null)
            {
                MessageBox.Show("Please select a Supporter.");
                return;
            }
            int supporterId = Convert.ToInt32(cmbSupporter.SelectedValue);
            DataTable contributions = _repo.GetSupporterContributions(supporterId);
            dgvContributions.DataSource = contributions;
        }

        
    }
}
