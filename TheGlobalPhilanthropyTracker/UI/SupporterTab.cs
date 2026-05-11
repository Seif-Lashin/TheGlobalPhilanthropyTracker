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
    public partial class SupporterTab : UserControl
    {
        private SupporterRepository _repo;

        public SupporterTab()
        {
            InitializeComponent();

            dgvSupporters.EnableHeadersVisualStyles = false;
            dgvSupporters.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvSupporters.BorderStyle = BorderStyle.None;
            dgvSupporters.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupporters.GridColor = Color.FromArgb(50, 50, 50);
            dgvSupporters.RowHeadersVisible = false;
            dgvSupporters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSupporters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSupporters.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvSupporters.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);
            dgvSupporters.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvSupporters.ColumnHeadersHeight = 35;

            dgvSupporters.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvSupporters.DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200);
            dgvSupporters.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 65);
            dgvSupporters.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSupporters.DefaultCellStyle.Padding = new Padding(5);
            dgvSupporters.RowTemplate.Height = 30;

            _repo = new SupporterRepository();
            LoadSupporters();
            // LoadInitiatives();
        }

        private void LoadSupporters()
        {
            dgvSupporters.DataSource = _repo.GetAllSupporters();
        }

        void LoadInitiatives()
        {
            // Lashin's
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("First Name and Email are required.");
                return;
            }

            var newSupporter = new Supporters
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text
            };

            _repo.RegisterSupporter(newSupporter);
            LoadSupporters();
            ClearRegistrationFields();
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            if (dgvSupporters.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                int id = Convert.ToInt32(dgvSupporters.SelectedRows[0].Cells["SupporterId"].Value);
                _repo.UpdateSupporterEmail(id, txtEmail.Text);
                LoadSupporters();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvSupporters.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSupporters.SelectedRows[0].Cells["SupporterId"].Value);
                try
                {
                    _repo.DeleteSupporter(id);
                    LoadSupporters();
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    // this is just to check if we made a foreign key violation
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Cannot delete this supporter because they have active contribution records.");
                    }
                    else throw;
                }
            }
        }

        private void btnSubmitContribution_Click(object sender, EventArgs e)
        {
            if (dgvSupporters.SelectedRows.Count == 0 || cmbInitiative.SelectedValue == null)
            {
                MessageBox.Show("Please select a supporter from the table and an initiative from the dropdown.");
                return;
            }

            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                int supporterId = Convert.ToInt32(dgvSupporters.SelectedRows[0].Cells["SupporterId"].Value);
                int initiativeId = Convert.ToInt32(cmbInitiative.SelectedValue);

                _repo.AddContribution(supporterId, initiativeId, amount);
                MessageBox.Show("Contribution logged successfully.");
                txtAmount.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void ClearRegistrationFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
        }
    }
}
