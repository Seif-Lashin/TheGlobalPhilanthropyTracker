using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Repositories;

namespace TheGlobalPhilanthropyTracker.UI
{
    public partial class AnalyticsTabB : UserControl
    {
        private readonly AnalyticsRepositoryB _repo = new AnalyticsRepositoryB();

        public AnalyticsTabB()
        {
            InitializeComponent();
        }

        private void btnUnspentInitiatives_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetUnspentInitiatives();
                lblStatus.Text = "Showing: Unspent Initiatives";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRecentActivity_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetRecentActivity();
                lblStatus.Text = "Showing: Recent Activity";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnSupporterProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetDetailedSupporterProfiles();
                lblStatus.Text = "Showing: Detailed Supporter Profiles";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}