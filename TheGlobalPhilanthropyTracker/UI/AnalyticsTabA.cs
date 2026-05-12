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
    public partial class AnalyticsTabA : UserControl
    {
        private readonly AnalyticsRepositoryA _repo = new AnalyticsRepositoryA();
        public AnalyticsTabA()
        {
            InitializeComponent();
        }
        private void btnTopSector_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetTopSector();
                lblStatus.Text = "Showing: Top Sectors";
                lblStatus.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void btnInactive_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetInactiveInitiatives();
                lblStatus.Text = "Showing: Inactive Initiatives";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void btnTopContributor_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMainOutput.DataSource = _repo.GetTopContributors();
                lblStatus.Text = "Showing: Top Contributors";
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

