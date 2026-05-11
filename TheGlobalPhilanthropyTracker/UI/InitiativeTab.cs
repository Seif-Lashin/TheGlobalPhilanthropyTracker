using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Models;
using TheGlobalPhilanthropyTracker.Repositories;
using TheGlobalPhilanthropyTracker.UI.InitiativeTabUtils;

namespace TheGlobalPhilanthropyTracker.UI
{
    public partial class InitiativeTab : UserControl
    {
        public InitiativeTab()
        {
            InitializeComponent();
            readInitiatives();
        }

        private void readInitiatives()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("InitiativeID", typeof(int));
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Primary Objective", typeof(string));
            dataTable.Columns.Add("Funding Target", typeof(decimal));
            dataTable.Columns.Add("Start Date", typeof(DateTime));
            dataTable.Columns.Add("End Date", typeof(DateTime));
            dataTable.Columns.Add("Sector", typeof(string));
            var repository = new InitiativeRepository();
            var initiatives = repository.GetInitiatives();
            var sectorRepository = new SectorRepository();

            foreach (var initiative in initiatives)
            {
                Sectors sector = new Sectors();
                sector = sectorRepository.GetSector(initiative.sectorId);
                dataTable.Rows.Add(initiative.initiativeId, initiative.title, initiative.primaryObjective, initiative.fundingTarget, initiative.startDate, initiative.endDate, sector.name);
            }

            this.initiativesTable.DataSource = dataTable;
        }

        private void btnAddInitiative_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readInitiatives();
            }
            else
            {
                Console.WriteLine("Initiative creation cancelled.");
            }
        }

        private void btnEditInitiative_Click(object sender, EventArgs e)
        {
            var val = this.initiativesTable.CurrentRow.Cells["InitiativeID"].Value.ToString();
            if (val == null || val.Length == 0) return;
            int id = Convert.ToInt32(val);

            var repo = new InitiativeRepository();
            var initiative = repo.GetInitiative(id);

            if (initiative == null) return;

            CreateEditForm form = new CreateEditForm();
            form.EditInitiative(initiative);
            if (form.ShowDialog() == DialogResult.OK)
            {
                readInitiatives();
            }
            else
            {
                Console.WriteLine("Initiative edit cancelled.");
            }
        }

        private void btnDeleteInitiative_Click(object sender, EventArgs e)
        {
            var val = this.initiativesTable.CurrentRow.Cells["InitiativeID"].Value.ToString();
            if (val == null || val.Length == 0) return;
            int id = Convert.ToInt32(val);

            var repo = new InitiativeRepository();
            repo.DeleteInitiative(id);
            readInitiatives();
        }

        private void initiativesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (initiativesTable.CurrentRow == null || initiativesTable.CurrentRow.Index < 0) return;

            var repo = new InitiativeRepository();
            var initiative = repo.GetInitiative(Convert.ToInt32(initiativesTable.CurrentRow.Cells["InitiativeID"].Value));

            if (initiative == null) return;

            if (!string.IsNullOrEmpty(initiative.impactSummaries))
            {
                this.rtbSummary.Text = initiative.impactSummaries;
                this.gbSummary.Visible = true;
            }
            else
            {
                this.rtbSummary.Text = "No impact summaries available.";
            }
        }
    }
}
