using static System.Net.Mime.MediaTypeNames;

namespace TheGlobalPhilanthropyTracker.UI
{
    partial class SectorTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        

        private void InitializeComponent()
        {
            var bg = Color.FromArgb(18, 18, 24);
            var surface = Color.FromArgb(28, 28, 38);
            var border = Color.FromArgb(45, 45, 62);
            var accent = Color.FromArgb(99, 179, 237);
            var danger = Color.FromArgb(220, 80, 80);
            var textPri = Color.FromArgb(220, 220, 230);

            sectorsTable = new DataGridView();
            label1 = new Label();
            btnAddSector = new Button();
            btnEditSector = new Button();
            btnDeleteSector = new Button();

            var pnlHeader = new Panel();
            var pnlToolbar = new Panel();
            var pnlContent = new Panel();

            ((System.ComponentModel.ISupportInitialize)sectorsTable).BeginInit();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 72;
            pnlHeader.BackColor = surface;
            pnlHeader.Padding = new Padding(28, 0, 0, 0);

            label1.Text = "🌐  Sectors";
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            label1.ForeColor = textPri;
            label1.Dock = DockStyle.Fill;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeader.Controls.Add(label1);

            // ── Toolbar ───────────────────────────────────────────
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 60;
            pnlToolbar.BackColor = bg;
            pnlToolbar.Padding = new Padding(24, 10, 24, 0);

            btnAddSector.Text = "＋  Add Sector";
            btnAddSector.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnAddSector.FlatStyle = FlatStyle.Flat;
            btnAddSector.FlatAppearance.BorderColor = accent;
            btnAddSector.FlatAppearance.BorderSize = 1;
            btnAddSector.BackColor = surface;
            btnAddSector.ForeColor = textPri;
            btnAddSector.Size = new Size(150, 36);
            btnAddSector.Location = new Point(0, 10);
            btnAddSector.Cursor = Cursors.Hand;

            btnEditSector.Text = "✏  Edit Sector";
            btnEditSector.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnEditSector.FlatStyle = FlatStyle.Flat;
            btnEditSector.FlatAppearance.BorderColor = border;
            btnEditSector.FlatAppearance.BorderSize = 1;
            btnEditSector.BackColor = surface;
            btnEditSector.ForeColor = textPri;
            btnEditSector.Size = new Size(150, 36);
            btnEditSector.Location = new Point(166, 10);
            btnEditSector.Cursor = Cursors.Hand;

            btnDeleteSector.Text = "🗑  Delete Sector";
            btnDeleteSector.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnDeleteSector.FlatStyle = FlatStyle.Flat;
            btnDeleteSector.FlatAppearance.BorderColor = danger;
            btnDeleteSector.FlatAppearance.BorderSize = 1;
            btnDeleteSector.BackColor = Color.FromArgb(50, 20, 20);
            btnDeleteSector.ForeColor = textPri;
            btnDeleteSector.Size = new Size(150, 36);
            btnDeleteSector.Location = new Point(332, 10);
            btnDeleteSector.Cursor = Cursors.Hand;

            btnAddSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 55, 75);
            btnAddSector.FlatAppearance.MouseDownBackColor = surface;
            btnEditSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 58);
            btnEditSector.FlatAppearance.MouseDownBackColor = surface;
            btnDeleteSector.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 25, 25);
            btnDeleteSector.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 20, 20);

            btnAddSector.Click += btnAddSector_Click;
            btnEditSector.Click += btnEditSector_Click;
            btnDeleteSector.Click += btnDeleteSector_Click;

            pnlToolbar.Controls.AddRange(new Control[] { btnAddSector, btnEditSector, btnDeleteSector });

            // ── Table ─────────────────────────────────────────────
            sectorsTable.Dock = DockStyle.Fill;
            sectorsTable.AllowUserToAddRows = false;
            sectorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sectorsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            sectorsTable.ColumnHeadersHeight = 38;
            sectorsTable.ReadOnly = true;
            sectorsTable.RowHeadersVisible = false;
            sectorsTable.MultiSelect = false;
            sectorsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sectorsTable.BackgroundColor = bg;
            sectorsTable.BorderStyle = BorderStyle.None;
            sectorsTable.GridColor = border;
            sectorsTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sectorsTable.EnableHeadersVisualStyles = false;
            sectorsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            sectorsTable.ColumnHeadersDefaultCellStyle.BackColor = surface;
            sectorsTable.ColumnHeadersDefaultCellStyle.ForeColor = accent;
            sectorsTable.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            sectorsTable.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            sectorsTable.DefaultCellStyle.BackColor = bg;
            sectorsTable.DefaultCellStyle.ForeColor = textPri;
            sectorsTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 75, 110);
            sectorsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            sectorsTable.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            sectorsTable.RowTemplate.Height = 34;
            sectorsTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 22, 32);
            sectorsTable.AlternatingRowsDefaultCellStyle.ForeColor = textPri;

            // ── UserControl ───────────────────────────────────────
            BackColor = bg;
            Controls.Add(sectorsTable);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "SectorTab";
            Size = new Size(1272, 686);

            ((System.ComponentModel.ISupportInitialize)sectorsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView sectorsTable;
        private Label label1;
        private Button btnAddSector;
        private Button btnEditSector;
        private Button btnDeleteSector;
    }
}