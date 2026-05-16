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
            this.dgvSupporters = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbInitiative = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSubmitContribution = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblInitiative = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.gbContribution = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupporters)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.gbRegistration.SuspendLayout();
            this.gbContribution.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color bg = System.Drawing.Color.FromArgb(18, 18, 24);
            System.Drawing.Color surface = System.Drawing.Color.FromArgb(28, 28, 38);
            System.Drawing.Color border = System.Drawing.Color.FromArgb(45, 45, 62);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(99, 179, 237);
            System.Drawing.Color danger = System.Drawing.Color.FromArgb(220, 80, 80);
            System.Drawing.Color textPri = System.Drawing.Color.FromArgb(220, 220, 230);
            System.Drawing.Color textMuted = System.Drawing.Color.FromArgb(150, 150, 170);
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(22, 22, 32);

            // pnlHeader
            this.pnlHeader.BackColor = surface;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1272, 72);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lblTitle.ForeColor = textPri;
            this.lblTitle.Location = new System.Drawing.Point(28, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1244, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🤝  Supporters";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dgvSupporters
            this.dgvSupporters.AllowUserToAddRows = false;
            this.dgvSupporters.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 32);
            this.dgvSupporters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupporters.BackgroundColor = bg;
            this.dgvSupporters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupporters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupporters.ColumnHeadersDefaultCellStyle.BackColor = surface;
            this.dgvSupporters.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.dgvSupporters.ColumnHeadersDefaultCellStyle.ForeColor = accent;
            this.dgvSupporters.ColumnHeadersHeight = 38;
            this.dgvSupporters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSupporters.DefaultCellStyle.BackColor = bg;
            this.dgvSupporters.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSupporters.DefaultCellStyle.ForeColor = textPri;
            this.dgvSupporters.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(45, 75, 110);
            this.dgvSupporters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupporters.EnableHeadersVisualStyles = false;
            this.dgvSupporters.GridColor = border;
            this.dgvSupporters.Location = new System.Drawing.Point(0, 72);
            this.dgvSupporters.MultiSelect = false;
            this.dgvSupporters.Name = "dgvSupporters";
            this.dgvSupporters.ReadOnly = true;
            this.dgvSupporters.RowHeadersVisible = false;
            this.dgvSupporters.RowTemplate.Height = 34;
            this.dgvSupporters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupporters.Size = new System.Drawing.Size(1272, 466);
            this.dgvSupporters.TabIndex = 1;

            // pnlBottom
            this.pnlBottom.BackColor = bg;
            this.pnlBottom.Controls.Add(this.gbRegistration);
            this.pnlBottom.Controls.Add(this.gbContribution);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 538);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(8);
            this.pnlBottom.Size = new System.Drawing.Size(1272, 148);
            this.pnlBottom.TabIndex = 2;

            // gbRegistration
            this.gbRegistration.BackColor = surface;
            this.gbRegistration.Controls.Add(this.btnRemove);
            this.gbRegistration.Controls.Add(this.btnUpdateEmail);
            this.gbRegistration.Controls.Add(this.btnRegister);
            this.gbRegistration.Controls.Add(this.txtEmail);
            this.gbRegistration.Controls.Add(this.lblEmail);
            this.gbRegistration.Controls.Add(this.txtLastName);
            this.gbRegistration.Controls.Add(this.lblLastName);
            this.gbRegistration.Controls.Add(this.txtFirstName);
            this.gbRegistration.Controls.Add(this.lblFirstName);
            this.gbRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbRegistration.ForeColor = accent;
            this.gbRegistration.Location = new System.Drawing.Point(16, 12);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(700, 120);
            this.gbRegistration.TabIndex = 0;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Register / Manage Supporter";

            // FirstName Controls
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = textMuted;
            this.lblFirstName.Location = new System.Drawing.Point(14, 28);
            this.lblFirstName.Text = "First Name";
            this.txtFirstName.BackColor = inputBg;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.ForeColor = textPri;
            this.txtFirstName.Location = new System.Drawing.Point(14, 46);
            this.txtFirstName.Size = new System.Drawing.Size(160, 23);

            // LastName Controls
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = textMuted;
            this.lblLastName.Location = new System.Drawing.Point(190, 28);
            this.lblLastName.Text = "Last Name";
            this.txtLastName.BackColor = inputBg;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.ForeColor = textPri;
            this.txtLastName.Location = new System.Drawing.Point(190, 46);
            this.txtLastName.Size = new System.Drawing.Size(160, 23);

            // Email Controls
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = textMuted;
            this.lblEmail.Location = new System.Drawing.Point(366, 28);
            this.lblEmail.Text = "Email";
            this.txtEmail.BackColor = inputBg;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = textPri;
            this.txtEmail.Location = new System.Drawing.Point(366, 46);
            this.txtEmail.Size = new System.Drawing.Size(210, 23);

            // Registration Buttons
            this.btnRegister.BackColor = surface;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderColor = accent;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(14, 80);
            this.btnRegister.Size = new System.Drawing.Size(138, 32);
            this.btnRegister.Text = "＋  Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnUpdateEmail.BackColor = surface;
            this.btnUpdateEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmail.FlatAppearance.BorderColor = border;
            this.btnUpdateEmail.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmail.Location = new System.Drawing.Point(162, 80);
            this.btnUpdateEmail.Size = new System.Drawing.Size(138, 32);
            this.btnUpdateEmail.Text = "✏  Update Email";
            this.btnUpdateEmail.Click += new System.EventHandler(this.btnUpdateEmail_Click);

            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(50, 20, 20);
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderColor = danger;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(544, 80);
            this.btnRemove.Size = new System.Drawing.Size(142, 32);
            this.btnRemove.Text = "🗑  Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // gbContribution
            this.gbContribution.BackColor = surface;
            this.gbContribution.Controls.Add(this.btnSubmitContribution);
            this.gbContribution.Controls.Add(this.txtAmount);
            this.gbContribution.Controls.Add(this.lblAmount);
            this.gbContribution.Controls.Add(this.cmbInitiative);
            this.gbContribution.Controls.Add(this.lblInitiative);
            this.gbContribution.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbContribution.ForeColor = accent;
            this.gbContribution.Location = new System.Drawing.Point(732, 12);
            this.gbContribution.Name = "gbContribution";
            this.gbContribution.Size = new System.Drawing.Size(430, 120);
            this.gbContribution.TabIndex = 1;
            this.gbContribution.TabStop = false;
            this.gbContribution.Text = "Log Contribution";

            this.lblInitiative.AutoSize = true;
            this.lblInitiative.ForeColor = textMuted;
            this.lblInitiative.Location = new System.Drawing.Point(14, 28);
            this.lblInitiative.Text = "Initiative";
            this.cmbInitiative.BackColor = inputBg;
            this.cmbInitiative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInitiative.ForeColor = textPri;
            this.cmbInitiative.Location = new System.Drawing.Point(14, 46);
            this.cmbInitiative.Size = new System.Drawing.Size(210, 23);

            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = textMuted;
            this.lblAmount.Location = new System.Drawing.Point(240, 28);
            this.lblAmount.Text = "Amount";
            this.txtAmount.BackColor = inputBg;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.ForeColor = textPri;
            this.txtAmount.Location = new System.Drawing.Point(240, 46);
            this.txtAmount.Size = new System.Drawing.Size(130, 23);

            this.btnSubmitContribution.BackColor = surface;
            this.btnSubmitContribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitContribution.FlatAppearance.BorderColor = accent;
            this.btnSubmitContribution.ForeColor = System.Drawing.Color.White;
            this.btnSubmitContribution.Location = new System.Drawing.Point(14, 80);
            this.btnSubmitContribution.Size = new System.Drawing.Size(190, 32);
            this.btnSubmitContribution.Text = "💳  Submit Contribution";
            this.btnSubmitContribution.Click += new System.EventHandler(this.btnSubmitContribution_Click);

            // SupporterTab
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = bg;
            this.Controls.Add(this.dgvSupporters);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SupporterTab";
            this.Size = new System.Drawing.Size(1272, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupporters)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.gbContribution.ResumeLayout(false);
            this.gbContribution.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupporters;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbInitiative;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSubmitContribution;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblInitiative;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.GroupBox gbContribution;
    }
}