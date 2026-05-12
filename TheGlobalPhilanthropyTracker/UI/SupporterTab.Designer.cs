namespace TheGlobalPhilanthropyTracker.UI
{
    partial class SupporterTab
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
            // ── Colour palette (matches SectorTab / AnalyticsTabA) ─────────
            var bg = Color.FromArgb(18, 18, 24);
            var surface = Color.FromArgb(28, 28, 38);
            var border = Color.FromArgb(45, 45, 62);
            var accent = Color.FromArgb(99, 179, 237);
            var danger = Color.FromArgb(220, 80, 80);
            var textPri = Color.FromArgb(220, 220, 230);
            var textMuted = Color.FromArgb(150, 150, 170);
            var inputBg = Color.FromArgb(22, 22, 32);
            var groupBg = Color.FromArgb(28, 28, 38);

            dgvSupporters = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            btnRegister = new Button();
            btnUpdateEmail = new Button();
            btnRemove = new Button();
            cmbInitiative = new ComboBox();
            txtAmount = new TextBox();
            btnSubmitContribution = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblInitiative = new Label();
            lblAmount = new Label();

            var pnlHeader = new Panel();
            var lblTitle = new Label();
            var pnlBottom = new Panel();
            var gbRegistration = new GroupBox();
            var gbContribution = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)dgvSupporters).BeginInit();
            gbRegistration.SuspendLayout();
            gbContribution.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();

            // ── Helpers ───────────────────────────────────────────────────
            void StyleLabel(Label lbl, string text, int x, int y)
            {
                lbl.Text = text;
                lbl.AutoSize = true;
                lbl.ForeColor = textMuted;
                lbl.Font = new Font("Segoe UI", 8.5F);
                lbl.Location = new Point(x, y);
            }

            void StyleTextBox(TextBox tb, int x, int y, int w = 160)
            {
                tb.BackColor = inputBg;
                tb.ForeColor = textPri;
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.Font = new Font("Segoe UI", 9F);
                tb.Location = new Point(x, y);
                tb.Size = new Size(w, 23);
            }

            void StyleComboBox(ComboBox cmb, int x, int y, int w = 200)
            {
                cmb.BackColor = inputBg;
                cmb.ForeColor = textPri;
                cmb.FlatStyle = FlatStyle.Flat;
                cmb.Font = new Font("Segoe UI", 9F);
                cmb.FormattingEnabled = true;
                cmb.Location = new Point(x, y);
                cmb.Size = new Size(w, 23);
            }

            void StyleButton(Button btn, string text, Color back, Color bord, int x, int y, int w = 140)
            {
                btn.Text = text;
                btn.Font = new Font("Segoe UI Semibold", 9F);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = bord;
                btn.FlatAppearance.BorderSize = 1;
                btn.BackColor = back;
                btn.ForeColor = Color.White;
                btn.Location = new Point(x, y);
                btn.Size = new Size(w, 32);
                btn.Cursor = Cursors.Hand;
                btn.UseVisualStyleBackColor = false;

                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(
                    Math.Min(back.R + 18, 255),
                    Math.Min(back.G + 18, 255),
                    Math.Min(back.B + 18, 255));
                btn.MouseLeave += (s, e) => btn.BackColor = back;
            }

            // ── Header panel ──────────────────────────────────────────────
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 72;
            pnlHeader.BackColor = surface;
            pnlHeader.Padding = new Padding(28, 0, 0, 0);

            lblTitle.Text = "🤝  Supporters";
            lblTitle.Font = new Font("Segoe UI Semibold", 17F);
            lblTitle.ForeColor = textPri;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            pnlHeader.Controls.Add(lblTitle);

            // ── DataGridView ──────────────────────────────────────────────
            dgvSupporters.Dock = DockStyle.Fill;
            dgvSupporters.AllowUserToAddRows = false;
            dgvSupporters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupporters.ReadOnly = true;
            dgvSupporters.BackgroundColor = bg;
            dgvSupporters.BorderStyle = BorderStyle.None;
            dgvSupporters.GridColor = border;
            dgvSupporters.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupporters.RowHeadersVisible = false;
            dgvSupporters.MultiSelect = false;
            dgvSupporters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupporters.EnableHeadersVisualStyles = false;
            dgvSupporters.ColumnHeadersHeight = 38;
            dgvSupporters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSupporters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSupporters.ColumnHeadersDefaultCellStyle.BackColor = surface;
            dgvSupporters.ColumnHeadersDefaultCellStyle.ForeColor = accent;
            dgvSupporters.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            dgvSupporters.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            dgvSupporters.DefaultCellStyle.BackColor = bg;
            dgvSupporters.DefaultCellStyle.ForeColor = textPri;
            dgvSupporters.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 75, 110);
            dgvSupporters.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSupporters.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            dgvSupporters.RowTemplate.Height = 34;
            dgvSupporters.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 22, 32);
            dgvSupporters.AlternatingRowsDefaultCellStyle.ForeColor = textPri;
            dgvSupporters.Name = "dgvSupporters";
            dgvSupporters.TabIndex = 10;

            // ── GroupBox: Register / Manage Supporter ─────────────────────
            gbRegistration.Text = "Register / Manage Supporter";
            gbRegistration.Font = new Font("Segoe UI", 9F);
            gbRegistration.ForeColor = accent;
            gbRegistration.BackColor = groupBg;
            gbRegistration.Location = new Point(16, 12);
            gbRegistration.Size = new Size(700, 120);

            StyleLabel(lblFirstName, "First Name", 14, 28);
            StyleTextBox(txtFirstName, 14, 46);
            txtFirstName.Name = "txtFirstName"; txtFirstName.TabIndex = 1;

            StyleLabel(lblLastName, "Last Name", 190, 28);
            StyleTextBox(txtLastName, 190, 46);
            txtLastName.Name = "txtLastName"; txtLastName.TabIndex = 2;

            StyleLabel(lblEmail, "Email", 366, 28);
            StyleTextBox(txtEmail, 366, 46, 210);
            txtEmail.Name = "txtEmail"; txtEmail.TabIndex = 3;

            StyleButton(btnRegister, "＋  Register", surface, accent, 14, 80, 138);
            btnRegister.Name = "btnRegister"; btnRegister.TabIndex = 4;
            btnRegister.Click += btnRegister_Click;

            StyleButton(btnUpdateEmail, "✏  Update Email", surface, border, 162, 80, 138);
            btnUpdateEmail.Name = "btnUpdateEmail"; btnUpdateEmail.TabIndex = 5;
            btnUpdateEmail.Click += btnUpdateEmail_Click;

            StyleButton(btnRemove, "🗑  Remove", Color.FromArgb(50, 20, 20), danger, 544, 80, 142);
            btnRemove.Name = "btnRemove"; btnRemove.TabIndex = 6;
            btnRemove.Click += btnRemove_Click;

            gbRegistration.Controls.AddRange(new Control[]
            {
                lblFirstName, txtFirstName,
                lblLastName,  txtLastName,
                lblEmail,     txtEmail,
                btnRegister, btnUpdateEmail, btnRemove
            });

            // ── GroupBox: Log Contribution ────────────────────────────────
            gbContribution.Text = "Log Contribution";
            gbContribution.Font = new Font("Segoe UI", 9F);
            gbContribution.ForeColor = accent;
            gbContribution.BackColor = groupBg;
            gbContribution.Location = new Point(732, 12);
            gbContribution.Size = new Size(430, 120);

            StyleLabel(lblInitiative, "Initiative", 14, 28);
            StyleComboBox(cmbInitiative, 14, 46, 210);
            cmbInitiative.Name = "cmbInitiative"; cmbInitiative.TabIndex = 7;

            StyleLabel(lblAmount, "Amount", 240, 28);
            StyleTextBox(txtAmount, 240, 46, 130);
            txtAmount.Name = "txtAmount"; txtAmount.TabIndex = 8;

            StyleButton(btnSubmitContribution, "💳  Submit Contribution", surface, accent, 14, 80, 190);
            btnSubmitContribution.Name = "btnSubmitContribution"; btnSubmitContribution.TabIndex = 9;
            btnSubmitContribution.Click += btnSubmitContribution_Click;

            gbContribution.Controls.AddRange(new Control[]
            {
                lblInitiative, cmbInitiative,
                lblAmount,     txtAmount,
                btnSubmitContribution
            });

            // ── Bottom form panel ─────────────────────────────────────────
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Height = 148;
            pnlBottom.BackColor = bg;
            pnlBottom.Padding = new Padding(8);
            pnlBottom.Controls.Add(gbRegistration);
            pnlBottom.Controls.Add(gbContribution);

            // ── UserControl ───────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = bg;
            ForeColor = textPri;
            Name = "SupporterTab";
            Size = new Size(1272, 686);

            // Order: Fill control added first, then Bottom, then Top (WinForms stacking)
            Controls.Add(dgvSupporters);
            Controls.Add(pnlBottom);
            Controls.Add(pnlHeader);

            ((System.ComponentModel.ISupportInitialize)dgvSupporters).EndInit();
            gbRegistration.ResumeLayout(false);
            gbRegistration.PerformLayout();
            gbContribution.ResumeLayout(false);
            gbContribution.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSupporters;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnUpdateEmail;
        private Button btnRemove;
        private ComboBox cmbInitiative;
        private TextBox txtAmount;
        private Button btnSubmitContribution;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblInitiative;
        private Label lblAmount;
    }
}