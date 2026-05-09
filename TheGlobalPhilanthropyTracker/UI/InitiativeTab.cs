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

            var repository = new InitiativeRepository();
            var initiatives = repository.GetInitiatives();

            foreach (var initiative in initiatives)
            {
                dataTable.Rows.Add(initiative.initiativeId, initiative.title, initiative.primaryObjective, initiative.fundingTarget, initiative.startDate, initiative.endDate);
            }

            this.initiativesTable.DataSource = dataTable;
        }
    }
}
