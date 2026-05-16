namespace TheGlobalPhilanthropyTracker.UI
{
    partial class AnalyticsTabA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void ApplyButtonHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(40, 40, 58);
                btn.FlatAppearance.BorderColor = Color.FromArgb(99, 179, 237);
            }
        }

        private void RemoveButtonHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(28, 28, 38);
                btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 62);
            }
        }

        private void InitializeComponent()
        {
            // ── Colour palette ────────────────────────────────────
            var bg = Color.FromArgb(18, 18, 24);
            var surface = Color.FromArgb(28, 28, 38);
            var border = Color.FromArgb(45, 45, 62);
            var accent = Color.FromArgb(99, 179, 237);   // sky-blue
            var textPri = Color.FromArgb(220, 220, 230);
            var textMuted = Color.FromArgb(130, 130, 150);
            var bodyFont = new Font("Segoe UI", 9.5F);
            var btnFont = new Font("Segoe UI Semibold", 9.5F);

            btnTopSector = new Button();
            btnInactive = new Button();
            btnTopContributor = new Button();
            lblStatus = new Label();
            dgvMainOutput = new DataGridView();
            var pnlButtons = new Panel();
            var pnlHeader = new Panel();
            var lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).BeginInit();
            SuspendLayout();

            // ── Header panel ──────────────────────────────────────
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 64;
            pnlHeader.BackColor = surface;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);

            lblTitle.Text = "Analytics — Overview";
            lblTitle.Font = new Font("Segoe UI Semibold", 15F);
            lblTitle.ForeColor = textPri;
            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeader.Controls.Add(lblTitle);

            // ── Button strip ─────────────────────────────────────
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Height = 64;
            pnlButtons.BackColor = bg;
            pnlButtons.Padding = new Padding(24, 12, 24, 0);

            // Helper: styled button
            btnTopSector.Text = "🏆  Top Sector";
            btnTopSector.Font = btnFont;
            btnTopSector.FlatStyle = FlatStyle.Flat;
            btnTopSector.FlatAppearance.BorderColor = border;
            btnTopSector.FlatAppearance.BorderSize = 1;
            btnTopSector.BackColor = surface;
            btnTopSector.ForeColor = textPri;
            btnTopSector.Size = new Size(220, 40);
            btnTopSector.Location = new Point(0, 12);
            btnTopSector.Cursor = Cursors.Hand;
            btnTopSector.TabStop = false;
            btnTopSector.MouseEnter += ApplyButtonHover;
            btnTopSector.MouseLeave += RemoveButtonHover;

            btnInactive.Text = "💤  Inactive Initiatives";
            btnInactive.Font = btnFont;
            btnInactive.FlatStyle = FlatStyle.Flat;
            btnInactive.FlatAppearance.BorderColor = border;
            btnInactive.FlatAppearance.BorderSize = 1;
            btnInactive.BackColor = surface;
            btnInactive.ForeColor = textPri;
            btnInactive.Size = new Size(220, 40);
            btnInactive.Location = new Point(236, 12);
            btnInactive.Cursor = Cursors.Hand;
            btnInactive.TabStop = false;
            btnInactive.MouseEnter += ApplyButtonHover;
            btnInactive.MouseLeave += RemoveButtonHover;

            btnTopContributor.Text = "💰  Top Contributor";
            btnTopContributor.Font = btnFont;
            btnTopContributor.FlatStyle = FlatStyle.Flat;
            btnTopContributor.FlatAppearance.BorderColor = border;
            btnTopContributor.FlatAppearance.BorderSize = 1;
            btnTopContributor.BackColor = surface;
            btnTopContributor.ForeColor = textPri;
            btnTopContributor.Size = new Size(220, 40);
            btnTopContributor.Location = new Point(472, 12);
            btnTopContributor.Cursor = Cursors.Hand;
            btnTopContributor.TabStop = false;
            btnTopContributor.MouseEnter += ApplyButtonHover;
            btnTopContributor.MouseLeave += RemoveButtonHover;

            btnTopSector.Click += btnTopSector_Click;
            btnInactive.Click += btnInactive_Click;
            btnTopContributor.Click += btnTopContributor_Click;

            pnlButtons.Controls.AddRange(new Control[] { btnTopSector, btnInactive, btnTopContributor });

            // ── Status label ──────────────────────────────────────
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Height = 28;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = textMuted;
            lblStatus.BackColor = bg;
            lblStatus.Text = "Select a report above to load data.";
            lblStatus.Padding = new Padding(28, 0, 0, 0);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // ── DataGridView ──────────────────────────────────────
            dgvMainOutput.Dock = DockStyle.Fill;
            dgvMainOutput.AllowUserToAddRows = false;
            dgvMainOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainOutput.ReadOnly = true;
            dgvMainOutput.BackgroundColor = bg;
            dgvMainOutput.BorderStyle = BorderStyle.None;
            dgvMainOutput.GridColor = border;
            dgvMainOutput.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMainOutput.RowHeadersVisible = false;
            dgvMainOutput.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainOutput.EnableHeadersVisualStyles = false;
            dgvMainOutput.ColumnHeadersHeight = 36;
            dgvMainOutput.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMainOutput.ColumnHeadersDefaultCellStyle.BackColor = surface;
            dgvMainOutput.ColumnHeadersDefaultCellStyle.ForeColor = accent;
            dgvMainOutput.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            dgvMainOutput.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgvMainOutput.DefaultCellStyle.BackColor = bg;
            dgvMainOutput.DefaultCellStyle.ForeColor = textPri;
            dgvMainOutput.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 75, 110);
            dgvMainOutput.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMainOutput.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgvMainOutput.RowTemplate.Height = 32;
            dgvMainOutput.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 22, 32);
            dgvMainOutput.AlternatingRowsDefaultCellStyle.ForeColor = textPri;

            // ── UserControl ───────────────────────────────────────
            BackColor = bg;
            Controls.Add(dgvMainOutput);
            Controls.Add(lblStatus);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Name = "AnalyticsTabA";
            Size = new Size(1272, 686);

            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).EndInit();
            ResumeLayout(false);
        }

        private Button btnTopSector;
        private Button btnInactive;
        private Button btnTopContributor;
        private Label lblStatus;
        private DataGridView dgvMainOutput;
    }
}