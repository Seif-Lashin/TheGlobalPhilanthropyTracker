using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Models;
using TheGlobalPhilanthropyTracker.Repositories;

namespace TheGlobalPhilanthropyTracker.UI.SectorTabUtils
{
    public partial class CreateEditForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(this.tbName.Text))
            {
                errorProvider.SetError(this.tbName, "Name is required.");
                isValid = false;
            }
            else if (this.tbName.Text.Length > 50)
            {
                errorProvider.SetError(this.tbName, "Name cannot exceed 50 characters.");
                isValid = false;
            }

            return isValid;
        }

        private int sectorId = 0;

        public void EditSector(Sectors sector)
        {
            this.Text = "Edit Sector";
            this.lbHeader.Text = "Edit Sector";

            this.lbID.Text = "" + sector.sectorId;
            this.tbName.Text = sector.name;
            this.tbDescription.Text = sector.description;

            this.sectorId = sector.sectorId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            try
            {
                Sectors sector = new Sectors();
                sector.sectorId = this.sectorId;
                sector.name = this.tbName.Text;
                sector.description = this.tbDescription.Text;

                var repo = new SectorRepository();

                if (sector.sectorId > 0)
                {
                    repo.UpdateSector(sector);
                }
                else repo.AddSector(sector);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the sector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}