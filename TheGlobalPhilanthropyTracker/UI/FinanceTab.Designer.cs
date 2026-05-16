namespace TheGlobalPhilanthropyTracker.UI
{
    partial class FinanceTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbInitiative = new ComboBox();
            cmbVendor = new ComboBox();
            txtAmount = new TextBox();
            dtpExpenditureDate = new DateTimePicker();
            btnAddExpenditure = new Button();
            lblInitiative = new Label();
            lblVendor = new Label();
            lblAmount = new Label();
            lblDate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnCancel = new Button();
            lblProgressInitiative = new Label();
            cmbProgressInitiative = new ComboBox();
            progressBarFunding = new ProgressBar();
            lblProgressPercent = new Label();
            btnCheckProgress = new Button();
            lblSelectSupporter = new Label();
            cmbSupporter = new ComboBox();
            btnReceipt = new Button();
            dgvContributions = new DataGridView();
            pnlHeader = new Panel();
            lblTitle = new Label();
            gbExpenditure = new GroupBox();
            gbProgress = new GroupBox();
            gbContributions = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvContributions).BeginInit();
            pnlHeader.SuspendLayout();
            gbExpenditure.SuspendLayout();
            gbProgress.SuspendLayout();
            gbContributions.SuspendLayout();
            SuspendLayout();
            // 
            // cmbInitiative
            // 
            cmbInitiative.BackColor = Color.FromArgb(28, 28, 38);
            cmbInitiative.FlatStyle = FlatStyle.Flat;
            cmbInitiative.ForeColor = Color.FromArgb(220, 220, 230);
            cmbInitiative.FormattingEnabled = true;
            cmbInitiative.Location = new Point(112, 36);
            cmbInitiative.Margin = new Padding(3, 2, 3, 2);
            cmbInitiative.Name = "cmbInitiative";
            cmbInitiative.Size = new Size(180, 23);
            cmbInitiative.TabIndex = 0;
            // 
            // cmbVendor
            // 
            cmbVendor.BackColor = Color.FromArgb(28, 28, 38);
            cmbVendor.FlatStyle = FlatStyle.Flat;
            cmbVendor.ForeColor = Color.FromArgb(220, 220, 230);
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(112, 78);
            cmbVendor.Margin = new Padding(3, 2, 3, 2);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(180, 23);
            cmbVendor.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(28, 28, 38);
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.ForeColor = Color.FromArgb(220, 220, 230);
            txtAmount.Location = new Point(112, 120);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(180, 23);
            txtAmount.TabIndex = 2;
            // 
            // dtpExpenditureDate
            // 
            dtpExpenditureDate.CalendarForeColor = Color.FromArgb(220, 220, 230);
            dtpExpenditureDate.CalendarMonthBackground = Color.FromArgb(28, 28, 38);
            dtpExpenditureDate.CalendarTitleBackColor = Color.FromArgb(18, 18, 24);
            dtpExpenditureDate.CalendarTitleForeColor = Color.FromArgb(99, 179, 237);
            dtpExpenditureDate.Format = DateTimePickerFormat.Short;
            dtpExpenditureDate.Location = new Point(112, 162);
            dtpExpenditureDate.Margin = new Padding(3, 2, 3, 2);
            dtpExpenditureDate.Name = "dtpExpenditureDate";
            dtpExpenditureDate.Size = new Size(180, 23);
            dtpExpenditureDate.TabIndex = 3;
            // 
            // btnAddExpenditure
            // 
            btnAddExpenditure.BackColor = Color.FromArgb(28, 28, 38);
            btnAddExpenditure.FlatAppearance.BorderColor = Color.FromArgb(99, 179, 237);
            btnAddExpenditure.FlatStyle = FlatStyle.Flat;
            btnAddExpenditure.ForeColor = Color.White;
            btnAddExpenditure.Location = new Point(204, 200);
            btnAddExpenditure.Margin = new Padding(3, 2, 3, 2);
            btnAddExpenditure.Name = "btnAddExpenditure";
            btnAddExpenditure.Size = new Size(140, 32);
            btnAddExpenditure.TabIndex = 4;
            btnAddExpenditure.Text = "＋  Add Expenditure";
            btnAddExpenditure.UseVisualStyleBackColor = false;
            btnAddExpenditure.Click += btnAddExpenditure_Click;
            // 
            // lblInitiative
            // 
            lblInitiative.AutoSize = true;
            lblInitiative.ForeColor = Color.FromArgb(180, 180, 195);
            lblInitiative.Location = new Point(16, 40);
            lblInitiative.Name = "lblInitiative";
            lblInitiative.Size = new Size(55, 15);
            lblInitiative.TabIndex = 5;
            lblInitiative.Text = "Initiative:";
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.ForeColor = Color.FromArgb(180, 180, 195);
            lblVendor.Location = new Point(16, 82);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(47, 15);
            lblVendor.TabIndex = 6;
            lblVendor.Text = "Vendor:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.ForeColor = Color.FromArgb(180, 180, 195);
            lblAmount.Location = new Point(16, 124);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.FromArgb(180, 180, 195);
            lblDate.Location = new Point(16, 166);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(28, 28, 38);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 100);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(200, 200, 210);
            btnCancel.Location = new Point(16, 200);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 32);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProgressInitiative
            // 
            lblProgressInitiative.AutoSize = true;
            lblProgressInitiative.ForeColor = Color.FromArgb(180, 180, 195);
            lblProgressInitiative.Location = new Point(16, 40);
            lblProgressInitiative.Name = "lblProgressInitiative";
            lblProgressInitiative.Size = new Size(55, 15);
            lblProgressInitiative.TabIndex = 11;
            lblProgressInitiative.Text = "Initiative:";
            // 
            // cmbProgressInitiative
            // 
            cmbProgressInitiative.BackColor = Color.FromArgb(28, 28, 38);
            cmbProgressInitiative.FlatStyle = FlatStyle.Flat;
            cmbProgressInitiative.ForeColor = Color.FromArgb(220, 220, 230);
            cmbProgressInitiative.FormattingEnabled = true;
            cmbProgressInitiative.Location = new Point(110, 36);
            cmbProgressInitiative.Margin = new Padding(3, 2, 3, 2);
            cmbProgressInitiative.Name = "cmbProgressInitiative";
            cmbProgressInitiative.Size = new Size(200, 23);
            cmbProgressInitiative.TabIndex = 12;
            // 
            // progressBarFunding
            // 
            progressBarFunding.BackColor = Color.FromArgb(28, 28, 38);
            progressBarFunding.ForeColor = Color.FromArgb(99, 179, 237);
            progressBarFunding.Location = new Point(16, 78);
            progressBarFunding.Margin = new Padding(3, 2, 3, 2);
            progressBarFunding.Name = "progressBarFunding";
            progressBarFunding.Size = new Size(260, 22);
            progressBarFunding.TabIndex = 13;
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.AutoSize = true;
            lblProgressPercent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProgressPercent.ForeColor = Color.FromArgb(99, 179, 237);
            lblProgressPercent.Location = new Point(288, 82);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new Size(67, 15);
            lblProgressPercent.TabIndex = 14;
            lblProgressPercent.Text = "0% funded";
            // 
            // btnCheckProgress
            // 
            btnCheckProgress.BackColor = Color.FromArgb(28, 28, 38);
            btnCheckProgress.FlatAppearance.BorderColor = Color.FromArgb(99, 179, 237);
            btnCheckProgress.FlatStyle = FlatStyle.Flat;
            btnCheckProgress.ForeColor = Color.White;
            btnCheckProgress.Location = new Point(16, 118);
            btnCheckProgress.Margin = new Padding(3, 2, 3, 2);
            btnCheckProgress.Name = "btnCheckProgress";
            btnCheckProgress.Size = new Size(140, 32);
            btnCheckProgress.TabIndex = 15;
            btnCheckProgress.Text = "Check Progress";
            btnCheckProgress.UseVisualStyleBackColor = false;
            btnCheckProgress.Click += btnCheckProgress_Click;
            // 
            // lblSelectSupporter
            // 
            lblSelectSupporter.AutoSize = true;
            lblSelectSupporter.ForeColor = Color.FromArgb(180, 180, 195);
            lblSelectSupporter.Location = new Point(16, 32);
            lblSelectSupporter.Name = "lblSelectSupporter";
            lblSelectSupporter.Size = new Size(96, 15);
            lblSelectSupporter.TabIndex = 17;
            lblSelectSupporter.Text = "Select Supporter:";
            // 
            // cmbSupporter
            // 
            cmbSupporter.BackColor = Color.FromArgb(28, 28, 38);
            cmbSupporter.FlatStyle = FlatStyle.Flat;
            cmbSupporter.ForeColor = Color.FromArgb(220, 220, 230);
            cmbSupporter.FormattingEnabled = true;
            cmbSupporter.Location = new Point(16, 56);
            cmbSupporter.Margin = new Padding(3, 2, 3, 2);
            cmbSupporter.Name = "cmbSupporter";
            cmbSupporter.Size = new Size(180, 23);
            cmbSupporter.TabIndex = 18;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.FromArgb(28, 28, 38);
            btnReceipt.FlatAppearance.BorderColor = Color.FromArgb(99, 179, 237);
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.ForeColor = Color.White;
            btnReceipt.Location = new Point(16, 90);
            btnReceipt.Margin = new Padding(3, 2, 3, 2);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(200, 32);
            btnReceipt.TabIndex = 19;
            btnReceipt.Text = "Show Contribution Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // dgvContributions
            // 
            dgvContributions.AllowUserToAddRows = false;
            dgvContributions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContributions.BackgroundColor = Color.FromArgb(18, 18, 24);
            dgvContributions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(99, 179, 237);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContributions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContributions.ColumnHeadersHeight = 38;
            dgvContributions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(99, 179, 237);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 75, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContributions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContributions.EnableHeadersVisualStyles = false;
            dgvContributions.Location = new Point(230, 24);
            dgvContributions.Margin = new Padding(3, 2, 3, 2);
            dgvContributions.Name = "dgvContributions";
            dgvContributions.RowHeadersVisible = false;
            dgvContributions.RowHeadersWidth = 51;
            dgvContributions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContributions.Size = new Size(530, 192);
            dgvContributions.TabIndex = 20;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(28, 28, 38);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 0, 0, 0);
            pnlHeader.Size = new Size(1225, 72);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Semibold", 17F);
            lblTitle.ForeColor = Color.FromArgb(220, 220, 230);
            lblTitle.Location = new Point(28, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1197, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰  Finance";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbExpenditure
            // 
            gbExpenditure.BackColor = Color.FromArgb(33, 33, 46);
            gbExpenditure.Controls.Add(cmbInitiative);
            gbExpenditure.Controls.Add(cmbVendor);
            gbExpenditure.Controls.Add(txtAmount);
            gbExpenditure.Controls.Add(dtpExpenditureDate);
            gbExpenditure.Controls.Add(btnAddExpenditure);
            gbExpenditure.Controls.Add(lblInitiative);
            gbExpenditure.Controls.Add(lblVendor);
            gbExpenditure.Controls.Add(lblAmount);
            gbExpenditure.Controls.Add(lblDate);
            gbExpenditure.Controls.Add(btnCancel);
            gbExpenditure.Font = new Font("Segoe UI", 9F);
            gbExpenditure.ForeColor = Color.FromArgb(99, 179, 237);
            gbExpenditure.Location = new Point(18, 82);
            gbExpenditure.Name = "gbExpenditure";
            gbExpenditure.Size = new Size(420, 248);
            gbExpenditure.TabIndex = 30;
            gbExpenditure.TabStop = false;
            gbExpenditure.Text = "Add Expenditure";
            // 
            // gbProgress
            // 
            gbProgress.BackColor = Color.FromArgb(33, 33, 46);
            gbProgress.Controls.Add(lblProgressInitiative);
            gbProgress.Controls.Add(cmbProgressInitiative);
            gbProgress.Controls.Add(progressBarFunding);
            gbProgress.Controls.Add(lblProgressPercent);
            gbProgress.Controls.Add(btnCheckProgress);
            gbProgress.Font = new Font("Segoe UI", 9F);
            gbProgress.ForeColor = Color.FromArgb(99, 179, 237);
            gbProgress.Location = new Point(460, 82);
            gbProgress.Name = "gbProgress";
            gbProgress.Size = new Size(360, 160);
            gbProgress.TabIndex = 31;
            gbProgress.TabStop = false;
            gbProgress.Text = "Funding Progress";
            // 
            // gbContributions
            // 
            gbContributions.BackColor = Color.FromArgb(33, 33, 46);
            gbContributions.Controls.Add(lblSelectSupporter);
            gbContributions.Controls.Add(cmbSupporter);
            gbContributions.Controls.Add(btnReceipt);
            gbContributions.Controls.Add(dgvContributions);
            gbContributions.Font = new Font("Segoe UI", 9F);
            gbContributions.ForeColor = Color.FromArgb(99, 179, 237);
            gbContributions.Location = new Point(18, 346);
            gbContributions.Name = "gbContributions";
            gbContributions.Size = new Size(780, 230);
            gbContributions.TabIndex = 32;
            gbContributions.TabStop = false;
            gbContributions.Text = "Contributions";
            // 
            // FinanceTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 24);
            Controls.Add(pnlHeader);
            Controls.Add(gbExpenditure);
            Controls.Add(gbProgress);
            Controls.Add(gbContributions);
            ForeColor = Color.FromArgb(220, 220, 230);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FinanceTab";
            Size = new Size(1225, 600);
            Load += FinanceTab_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContributions).EndInit();
            pnlHeader.ResumeLayout(false);
            gbExpenditure.ResumeLayout(false);
            gbExpenditure.PerformLayout();
            gbProgress.ResumeLayout(false);
            gbProgress.PerformLayout();
            gbContributions.ResumeLayout(false);
            gbContributions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox gbExpenditure;
        private GroupBox gbProgress;
        private GroupBox gbContributions;
        private ComboBox cmbInitiative;
        private ComboBox cmbVendor;
        private TextBox txtAmount;
        private DateTimePicker dtpExpenditureDate;
        private Button btnAddExpenditure;
        private Label lblInitiative;
        private Label lblVendor;
        private Label lblAmount;
        private Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private Button btnCancel;
        private Label lblProgressInitiative;
        private ComboBox cmbProgressInitiative;
        private ProgressBar progressBarFunding;
        private Label lblProgressPercent;
        private Button btnCheckProgress;
        private Label lblSelectSupporter;
        private ComboBox cmbSupporter;
        private Button btnReceipt;
        private DataGridView dgvContributions;
    }
}