namespace TheGlobalPhilanthropyTracker.UI
{
    partial class AnalyticsTabB
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

        private void InitializeComponent()
        {
            btnUnspentInitiatives = new Button();
            btnRecentActivity = new Button();
            btnSupporterProfiles = new Button();
            lblStatus = new Label();
            dgvMainOutput = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).BeginInit();
            SuspendLayout();
            // 
            // btnUnspentInitiatives
            // 
            btnUnspentInitiatives.Location = new Point(12, 12);
            btnUnspentInitiatives.Name = "btnUnspentInitiatives";
            btnUnspentInitiatives.Size = new Size(228, 45);
            btnUnspentInitiatives.TabIndex = 0;
            btnUnspentInitiatives.Text = "💸 Unspent Initiatives";
            btnUnspentInitiatives.Click += btnUnspentInitiatives_Click;
            // 
            // btnRecentActivity
            // 
            btnRecentActivity.Anchor = AnchorStyles.Top;
            btnRecentActivity.Location = new Point(271, 12);
            btnRecentActivity.Name = "btnRecentActivity";
            btnRecentActivity.Size = new Size(225, 45);
            btnRecentActivity.TabIndex = 1;
            btnRecentActivity.Text = "🕐 Recent Activity";
            btnRecentActivity.Click += btnRecentActivity_Click;
            // 
            // btnSupporterProfiles
            // 
            btnSupporterProfiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSupporterProfiles.Location = new Point(530, 12);
            btnSupporterProfiles.Name = "btnSupporterProfiles";
            btnSupporterProfiles.Size = new Size(215, 45);
            btnSupporterProfiles.TabIndex = 2;
            btnSupporterProfiles.Text = "👤 Supporter Profiles";
            btnSupporterProfiles.Click += btnSupporterProfiles_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(12, 65);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(750, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Click a button above to load data.";
            // 
            // dgvMainOutput
            // 
            dgvMainOutput.AllowUserToAddRows = false;
            dgvMainOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMainOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainOutput.BackgroundColor = SystemColors.Window;
            dgvMainOutput.ColumnHeadersHeight = 29;
            dgvMainOutput.Location = new Point(12, 98);
            dgvMainOutput.Name = "dgvMainOutput";
            dgvMainOutput.ReadOnly = true;
            dgvMainOutput.RowHeadersWidth = 51;
            dgvMainOutput.Size = new Size(750, 300);
            dgvMainOutput.TabIndex = 4;
            // 
            // AnalyticsTabB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUnspentInitiatives);
            Controls.Add(btnRecentActivity);
            Controls.Add(btnSupporterProfiles);
            Controls.Add(lblStatus);
            Controls.Add(dgvMainOutput);
            Name = "AnalyticsTabB";
            Size = new Size(780, 419);
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