using System;
using System.Drawing;
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
            dgvSupporters.MultiSelect = false;
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

            dgvSupporters.SelectionChanged += dgvSupporters_SelectionChanged;

            _repo = new SupporterRepository();
            LoadSupporters();
            LoadInitiatives();
        }

        private void LoadSupporters()
        {
            dgvSupporters.DataSource = _repo.GetAllSupporters();
        }

        void LoadInitiatives()
        {
            var initiativeRepo = new InitiativeRepository();
            var initiatives = initiativeRepo.GetInitiatives();

            cmbInitiative.DataSource = initiatives;
            cmbInitiative.DisplayMember = "title";
            cmbInitiative.ValueMember = "initiativeId";
            cmbInitiative.SelectedIndex = -1;
        }

        private void dgvSupporters_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSupporters.SelectedRows.Count > 0)
            {
                var supporter = (Supporters)dgvSupporters.SelectedRows[0].DataBoundItem;
                if (supporter != null)
                {
                    txtFirstName.Text = supporter.FirstName;
                    txtLastName.Text = supporter.LastName;
                    txtEmail.Text = supporter.Email;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("First Name, Last Name, and Email are all required.");
                return;
            }

            if (firstName.Length > 50 || lastName.Length > 50)
            {
                MessageBox.Show("First Name and Last Name must not exceed 50 characters.");
                return;
            }

            if (email.Length > 100)
            {
                MessageBox.Show("Email must not exceed 100 characters.");
                return;
            }

            var newSupporter = new Supporters
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            try
            {
                _repo.RegisterSupporter(newSupporter);
                LoadSupporters();
                ClearRegistrationFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register supporter. Database error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            if (dgvSupporters.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string newEmail = txtEmail.Text.Trim();

                if (newEmail.Length > 100)
                {
                    MessageBox.Show("Email must not exceed 100 characters.");
                    return;
                }

                try
                {
                    int id = Convert.ToInt32(dgvSupporters.SelectedRows[0].Cells["SupporterId"].Value);
                    _repo.UpdateSupporterEmail(id, newEmail);
                    LoadSupporters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update email. Database error: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    ClearRegistrationFields();
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    // this is just to check if we made a foreign key violation
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Cannot delete this supporter because they have active contribution records.");
                    }
                    else
                    {
                        MessageBox.Show($"Database error: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (decimal.TryParse(txtAmount.Text, out decimal amount) && amount > 0)
            {
                try
                {
                    int supporterId = Convert.ToInt32(dgvSupporters.SelectedRows[0].Cells["SupporterId"].Value);
                    int initiativeId = Convert.ToInt32(cmbInitiative.SelectedValue);

                    _repo.AddContribution(supporterId, initiativeId, amount);
                    MessageBox.Show("Contribution logged successfully.");
                    txtAmount.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to log contribution. Database error: {ex.Message}", "Contribution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive amount.");
            }
        }

        private void ClearRegistrationFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            dgvSupporters.ClearSelection();
        }
    }
}