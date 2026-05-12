namespace TheGlobalPhilanthropyTracker.UI
{
    partial class AnalyticsTabB
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var bg = Color.FromArgb(18, 18, 24);
            var surface = Color.FromArgb(28, 28, 38);
            var border = Color.FromArgb(45, 45, 62);
            var accent = Color.FromArgb(99, 179, 237);
            var textPri = Color.FromArgb(220, 220, 230);
            var textMuted = Color.FromArgb(130, 130, 150);
            var btnFont = new Font("Segoe UI Semibold", 9.5F);

            btnUnspentInitiatives = new Button();
            btnRecentActivity = new Button();
            btnSupporterProfiles = new Button();
            lblStatus = new Label();
            dgvMainOutput = new DataGridView();
            var pnlButtons = new Panel();
            var pnlHeader = new Panel();
            var lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).BeginInit();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 64;
            pnlHeader.BackColor = surface;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);

            lblTitle.Text = "Analytics — Deep Dive";
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

            void StyleBtn(Button btn, string text, int left)
            {
                btn.Text = text;
                btn.Font = btnFont;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = border;
                btn.FlatAppearance.BorderSize = 1;
                btn.BackColor = surface;
                btn.ForeColor = textPri;
                btn.Size = new Size(220, 40);
                btn.Location = new Point(left, 12);
                btn.Cursor = Cursors.Hand;
                btn.TabStop = false;

                btn.MouseEnter += (s, e) => { btn.BackColor = Color.FromArgb(40, 40, 58); btn.FlatAppearance.BorderColor = accent; };
                btn.MouseLeave += (s, e) => { btn.BackColor = surface; btn.FlatAppearance.BorderColor = border; };
            }

            StyleBtn(btnUnspentInitiatives, "💸  Unspent Initiatives", 0);
            StyleBtn(btnRecentActivity, "🕐  Recent Activity", 236);
            StyleBtn(btnSupporterProfiles, "👤  Supporter Profiles", 472);

            btnUnspentInitiatives.Click += btnUnspentInitiatives_Click;
            btnRecentActivity.Click += btnRecentActivity_Click;
            btnSupporterProfiles.Click += btnSupporterProfiles_Click;

            pnlButtons.Controls.AddRange(new Control[] { btnUnspentInitiatives, btnRecentActivity, btnSupporterProfiles });

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
            Name = "AnalyticsTabB";
            Size = new Size(1272, 686);

            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).EndInit();
            ResumeLayout(false);
        }

        private Button btnUnspentInitiatives;
        private Button btnRecentActivity;
        private Button btnSupporterProfiles;
        private Label lblStatus;
        private DataGridView dgvMainOutput;
    }
}