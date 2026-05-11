using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheGlobalPhilanthropyTracker.Models;
using TheGlobalPhilanthropyTracker.Repositories;
using TheGlobalPhilanthropyTracker.UI.SectorTabUtils;

namespace TheGlobalPhilanthropyTracker.UI
{
    public partial class SectorTab : UserControl
    {
        public SectorTab()
        {
            InitializeComponent();
            readSectors();
        }

        private void readSectors()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SectorID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            var repository = new SectorRepository();
            var sectors = repository.GetSectors();

            foreach (var sector in sectors)
            {
                dataTable.Rows.Add(sector.sectorId, sector.name, sector.description);
            }

            this.sectorsTable.DataSource = dataTable;
        }

        private void btnAddSector_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readSectors();
            }
            else
            {
                Console.WriteLine("Sector creation cancelled.");
            }
        }

        private void btnEditSector_Click(object sender, EventArgs e)
        {
            if(this.sectorsTable.CurrentRow == null || this.sectorsTable.CurrentRow.Index < 0) return;
            var val = this.sectorsTable.CurrentRow.Cells["SectorID"].Value;
            if (val == null || val == DBNull.Value) return;

            int id = Convert.ToInt32(val);

            var repo = new SectorRepository();
            var sector = repo.GetSector(id);

            if (sector == null) return;

            CreateEditForm form = new CreateEditForm();
            form.EditSector(sector);
            if (form.ShowDialog() == DialogResult.OK)
            {
                readSectors();
            }
            else
            {
                Console.WriteLine("Sector edit cancelled.");
            }
        }

        private void btnDeleteSector_Click(object sender, EventArgs e)
        {
            if(this.sectorsTable.CurrentRow == null || this.sectorsTable.CurrentRow.Index < 0) return;
            var val = this.sectorsTable.CurrentRow.Cells["SectorID"].Value;
            if (val == null || val == DBNull.Value) return;

            int id = Convert.ToInt32(val);

            var repo = new SectorRepository();
            repo.DeleteSector(id);
            readSectors();
        }
    }
}