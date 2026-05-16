using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Models;
using TheGlobalPhilanthropyTracker.Repositories;

namespace TheGlobalPhilanthropyTracker.UI.InitiativeTabUtils
{
    public partial class CreateEditForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            loadSectors();
            errorProvider.ContainerControl = this;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(this.tbTitle.Text))
            {
                errorProvider.SetError(this.tbTitle, "Title is required.");
                isValid = false;
            }
            else if (this.tbTitle.Text.Length > 100)
            {
                errorProvider.SetError(this.tbTitle, "Title cannot exceed 100 characters.");
                isValid = false;
            }

            if (this.cbSector.SelectedValue == null)
            {
                errorProvider.SetError(this.cbSector, "Please select a valid sector.");
                isValid = false;
            }

            if (this.dtEnd.Value.Date < this.dtStart.Value.Date)
            {
                errorProvider.SetError(this.dtEnd, "End Date cannot be before Start Date.");
                isValid = false;
            }

            if (this.numericUpDownTarget.Value < 1)
            {
                errorProvider.SetError(this.numericUpDownTarget, "Target must be at least 1.");
                isValid = false;
            }

            return isValid;
        }

        private int initiativeId = 0;
        public void EditInitiative(Initiatives initiative)
        {
            this.Text = "Edit Initiative";
            this.lbHeader.Text = "Edit Initiative";

            this.lbID.Text = "" + initiative.initiativeId;
            this.tbTitle.Text = initiative.title;
            this.tbObjective.Text = initiative.primaryObjective;
            this.tbSummary.Text = initiative.impactSummaries;
            this.dtStart.Value = initiative.startDate ?? DateTime.Now;
            this.dtEnd.Value = initiative.endDate ?? DateTime.Now;
            this.numericUpDownTarget.Value = initiative.fundingTarget ?? 1;
            this.cbSector.SelectedValue = initiative.sectorId;

            this.initiativeId = initiative.initiativeId;
        }
        private void loadSectors()
        {
            var repo = new SectorRepository();
            var sectors = repo.GetSectors();
            this.cbSector.DataSource = sectors;
            this.cbSector.DisplayMember = "name";
            this.cbSector.ValueMember = "sectorId";
            this.cbSector.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateInputs())
            {
                return;
            }
            try
            {
                Initiatives initiative = new Initiatives();
                initiative.initiativeId = this.initiativeId;
                initiative.sectorId = this.cbSector.SelectedValue != null ? (int)this.cbSector.SelectedValue : -1;
                initiative.primaryObjective = this.tbObjective.Text;
                initiative.title = this.tbTitle.Text;
                initiative.impactSummaries = this.tbSummary.Text;
                initiative.startDate = this.dtStart.Value.Date;
                initiative.endDate = this.dtEnd.Value.Date;
                initiative.fundingTarget = this.numericUpDownTarget.Value;

                var repo = new InitiativeRepository();

                if(initiative.initiativeId > 0)
                {
                    repo.UpdateInitiative(initiative);
                }
                else repo.CreateInitiative(initiative);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the initiative: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
