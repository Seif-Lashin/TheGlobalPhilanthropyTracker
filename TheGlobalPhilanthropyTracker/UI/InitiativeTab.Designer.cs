namespace TheGlobalPhilanthropyTracker.UI
{
    partial class InitiativeTab
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            initiativesTable = new DataGridView();
            label1 = new Label();
            btnAddInitiative = new Button();
            btnEditInitiative = new Button();
            btnDeleteInitiative = new Button();
            gbSummary = new GroupBox();
            label2 = new Label();
            lbTotal = new Label();
            label5 = new Label();
            lbCount = new Label();
            rtbSummary = new RichTextBox();
            pnlHeader = new Panel();
            pnlToolbar = new Panel();
            pnlSummaryWrap = new Panel();
            ((System.ComponentModel.ISupportInitialize)initiativesTable).BeginInit();
            gbSummary.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlSummaryWrap.SuspendLayout();
            SuspendLayout();

            // ── initiativesTable ──────────────────────────────────
            // Changed from Anchor to Dock.Fill to match SectorTab behavior
            initiativesTable.Dock = DockStyle.Fill;
            initiativesTable.BackgroundColor = Color.FromArgb(18, 18, 24);
            initiativesTable.BorderStyle = BorderStyle.None;
            initiativesTable.AllowUserToAddRows = false;
            initiativesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(99, 179, 237);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            initiativesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            initiativesTable.ColumnHeadersHeight = 38;
            initiativesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 75, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            initiativesTable.DefaultCellStyle = dataGridViewCellStyle2;

            initiativesTable.EnableHeadersVisualStyles = false;
            initiativesTable.Name = "initiativesTable";
            initiativesTable.RowHeadersVisible = false;
            initiativesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            initiativesTable.TabIndex = 0;
            initiativesTable.SelectionChanged += initiativesTable_SelectionChanged;

            // ── label1 ────────────────────────────────────────────
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 17F);
            label1.ForeColor = Color.FromArgb(220, 220, 230);
            label1.Location = new Point(28, 0);
            label1.Name = "label1";
            label1.Size = new Size(1244, 72);
            label1.TabIndex = 0;
            label1.Text = "🎯  Initiatives";
            label1.TextAlign = ContentAlignment.MiddleLeft;

            // ── btnAddInitiative ──────────────────────────────────
            btnAddInitiative.BackColor = Color.FromArgb(28, 28, 38);
            btnAddInitiative.FlatAppearance.BorderColor = Color.FromArgb(99, 179, 237);
            btnAddInitiative.FlatStyle = FlatStyle.Flat;
            btnAddInitiative.ForeColor = Color.White;
            btnAddInitiative.Location = new Point(24, 10);
            btnAddInitiative.Name = "btnAddInitiative";
            btnAddInitiative.Size = new Size(160, 36);
            btnAddInitiative.TabIndex = 0;
            btnAddInitiative.Text = "＋  Add Initiative";
            btnAddInitiative.Click += btnAddInitiative_Click;

            // ── btnEditInitiative ─────────────────────────────────
            btnEditInitiative.BackColor = Color.FromArgb(28, 28, 38);
            btnEditInitiative.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 62);
            btnEditInitiative.FlatStyle = FlatStyle.Flat;
            btnEditInitiative.ForeColor = Color.White;
            btnEditInitiative.Location = new Point(200, 10);
            btnEditInitiative.Name = "btnEditInitiative";
            btnEditInitiative.Size = new Size(160, 36);
            btnEditInitiative.TabIndex = 1;
            btnEditInitiative.Text = "✏  Edit Initiative";
            btnEditInitiative.Click += btnEditInitiative_Click;

            // ── btnDeleteInitiative ───────────────────────────────
            btnDeleteInitiative.BackColor = Color.FromArgb(50, 20, 20);
            btnDeleteInitiative.FlatAppearance.BorderColor = Color.FromArgb(220, 80, 80);
            btnDeleteInitiative.FlatStyle = FlatStyle.Flat;
            btnDeleteInitiative.ForeColor = Color.White;
            btnDeleteInitiative.Location = new Point(376, 10);
            btnDeleteInitiative.Name = "btnDeleteInitiative";
            btnDeleteInitiative.Size = new Size(160, 36);
            btnDeleteInitiative.TabIndex = 2;
            btnDeleteInitiative.Text = "🗑  Delete Initiative";
            btnDeleteInitiative.Click += btnDeleteInitiative_Click;

            // ── gbSummary ─────────────────────────────────────────
            gbSummary.BackColor = Color.FromArgb(33, 33, 46);
            gbSummary.Controls.Add(label2);
            gbSummary.Controls.Add(lbTotal);
            gbSummary.Controls.Add(label5);
            gbSummary.Controls.Add(lbCount);
            gbSummary.Controls.Add(rtbSummary);
            gbSummary.Dock = DockStyle.Fill;
            gbSummary.ForeColor = Color.FromArgb(99, 179, 237);
            gbSummary.Location = new Point(24, 12);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(1224, 156);
            gbSummary.TabIndex = 0;
            gbSummary.TabStop = false;
            gbSummary.Text = "Impact Summary";

            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 28);
            label2.Text = "Total Contributions";

            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbTotal.Location = new Point(16, 48);

            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(16, 88);
            label5.Text = "Contributions Count";

            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbCount.Location = new Point(16, 108);

            rtbSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbSummary.BackColor = Color.FromArgb(22, 22, 32);
            rtbSummary.BorderStyle = BorderStyle.None;
            rtbSummary.ForeColor = Color.White;
            rtbSummary.Location = new Point(240, 25);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.ReadOnly = true;
            rtbSummary.Size = new Size(960, 120); // Fixed size to fit inside gbSummary properly
            rtbSummary.TabIndex = 4;

            // ── Panels Setup ──────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(28, 28, 38);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 72;
            pnlHeader.Padding = new Padding(28, 0, 0, 0);

            pnlToolbar.BackColor = Color.FromArgb(18, 18, 24);
            pnlToolbar.Controls.Add(btnAddInitiative);
            pnlToolbar.Controls.Add(btnEditInitiative);
            pnlToolbar.Controls.Add(btnDeleteInitiative);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 60;
            pnlToolbar.Padding = new Padding(24, 10, 24, 0);

            pnlSummaryWrap.BackColor = Color.FromArgb(18, 18, 24);
            pnlSummaryWrap.Controls.Add(gbSummary);
            pnlSummaryWrap.Dock = DockStyle.Top;
            pnlSummaryWrap.Height = 180;
            pnlSummaryWrap.Padding = new Padding(24, 12, 24, 12);

            // ── InitiativeTab UserControl ─────────────────────────
            BackColor = Color.FromArgb(18, 18, 24);
            Size = new Size(1272, 686);

            // ORDER MATTERS: Add Dock.Fill control LAST
            Controls.Add(initiativesTable);
            Controls.Add(pnlSummaryWrap);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);

            Name = "InitiativeTab";
            ((System.ComponentModel.ISupportInitialize)initiativesTable).EndInit();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlSummaryWrap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView initiativesTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddInitiative;
        private System.Windows.Forms.Button btnEditInitiative;
        private System.Windows.Forms.Button btnDeleteInitiative;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label2;
        private Panel pnlHeader;
        private Panel pnlToolbar;
        private Panel pnlSummaryWrap;
    }
}