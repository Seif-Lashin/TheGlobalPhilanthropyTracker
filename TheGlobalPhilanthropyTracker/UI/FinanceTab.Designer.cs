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
            ((System.ComponentModel.ISupportInitialize)dgvContributions).BeginInit();
            SuspendLayout();
            // 
            // cmbInitiative
            // 
            cmbInitiative.FormattingEnabled = true;
            cmbInitiative.Location = new Point(148, 39);
            cmbInitiative.Name = "cmbInitiative";
            cmbInitiative.Size = new Size(151, 28);
            cmbInitiative.TabIndex = 0;
            // 
            // cmbVendor
            // 
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(148, 99);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(151, 28);
            cmbVendor.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(148, 157);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 2;
            // 
            // dtpExpenditureDate
            // 
            dtpExpenditureDate.Location = new Point(148, 220);
            dtpExpenditureDate.Name = "dtpExpenditureDate";
            dtpExpenditureDate.Size = new Size(260, 27);
            dtpExpenditureDate.TabIndex = 3;
            // 
            // btnAddExpenditure
            // 
            btnAddExpenditure.Location = new Point(256, 275);
            btnAddExpenditure.Name = "btnAddExpenditure";
            btnAddExpenditure.Size = new Size(152, 29);
            btnAddExpenditure.TabIndex = 4;
            btnAddExpenditure.Text = "Add Expenditure";
            btnAddExpenditure.UseVisualStyleBackColor = true;
            btnAddExpenditure.Click += btnAddExpenditure_Click;
            // 
            // lblInitiative
            // 
            lblInitiative.AutoSize = true;
            lblInitiative.Location = new Point(43, 47);
            lblInitiative.Name = "lblInitiative";
            lblInitiative.Size = new Size(73, 20);
            lblInitiative.TabIndex = 5;
            lblInitiative.Text = "Initiative: ";
            // 
            // lblVendor
            // 
            lblVendor.AutoSize = true;
            lblVendor.Location = new Point(43, 107);
            lblVendor.Name = "lblVendor";
            lblVendor.Size = new Size(63, 20);
            lblVendor.TabIndex = 6;
            lblVendor.Text = "Vendor: ";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(43, 164);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(69, 20);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(43, 225);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 20);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date: ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(43, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProgressInitiative
            // 
            lblProgressInitiative.Location = new Point(634, 50);
            lblProgressInitiative.Name = "lblProgressInitiative";
            lblProgressInitiative.Size = new Size(86, 28);
            lblProgressInitiative.TabIndex = 11;
            lblProgressInitiative.Text = "Initiative:";
            // 
            // cmbProgressInitiative
            // 
            cmbProgressInitiative.FormattingEnabled = true;
            cmbProgressInitiative.Location = new Point(763, 50);
            cmbProgressInitiative.Name = "cmbProgressInitiative";
            cmbProgressInitiative.Size = new Size(151, 28);
            cmbProgressInitiative.TabIndex = 12;
            // 
            // progressBarFunding
            // 
            progressBarFunding.Location = new Point(634, 107);
            progressBarFunding.Name = "progressBarFunding";
            progressBarFunding.Size = new Size(256, 29);
            progressBarFunding.TabIndex = 13;
            // 
            // lblProgressPercent
            // 
            lblProgressPercent.Location = new Point(896, 111);
            lblProgressPercent.Name = "lblProgressPercent";
            lblProgressPercent.Size = new Size(81, 25);
            lblProgressPercent.TabIndex = 14;
            lblProgressPercent.Text = "lblProgressPercent";
            // 
            // btnCheckProgress
            // 
            btnCheckProgress.Location = new Point(837, 164);
            btnCheckProgress.Name = "btnCheckProgress";
            btnCheckProgress.Size = new Size(140, 29);
            btnCheckProgress.TabIndex = 15;
            btnCheckProgress.Text = "Check Progress";
            btnCheckProgress.UseVisualStyleBackColor = true;
            btnCheckProgress.Click += btnCheckProgress_Click;
            // 
            // lblSelectSupporter
            // 
            lblSelectSupporter.Location = new Point(20, 421);
            lblSelectSupporter.Name = "lblSelectSupporter";
            lblSelectSupporter.Size = new Size(122, 25);
            lblSelectSupporter.TabIndex = 17;
            lblSelectSupporter.Text = "Select Supporter:";
            // 
            // cmbSupporter
            // 
            cmbSupporter.FormattingEnabled = true;
            cmbSupporter.Location = new Point(20, 464);
            cmbSupporter.Name = "cmbSupporter";
            cmbSupporter.Size = new Size(151, 28);
            cmbSupporter.TabIndex = 18;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(20, 512);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(186, 29);
            btnReceipt.TabIndex = 19;
            btnReceipt.Text = "Generate Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // dgvContributions
            // 
            dgvContributions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContributions.Location = new Point(256, 434);
            dgvContributions.Name = "dgvContributions";
            dgvContributions.RowHeadersWidth = 51;
            dgvContributions.Size = new Size(483, 139);
            dgvContributions.TabIndex = 20;
            // 
            // FinanceTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvContributions);
            Controls.Add(btnReceipt);
            Controls.Add(cmbSupporter);
            Controls.Add(lblSelectSupporter);
            Controls.Add(btnCheckProgress);
            Controls.Add(lblProgressPercent);
            Controls.Add(progressBarFunding);
            Controls.Add(cmbProgressInitiative);
            Controls.Add(lblProgressInitiative);
            Controls.Add(btnCancel);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(lblVendor);
            Controls.Add(lblInitiative);
            Controls.Add(btnAddExpenditure);
            Controls.Add(dtpExpenditureDate);
            Controls.Add(txtAmount);
            Controls.Add(cmbVendor);
            Controls.Add(cmbInitiative);
            Name = "FinanceTab";
            Size = new Size(1400, 800);
            Load += FinanceTab_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContributions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
