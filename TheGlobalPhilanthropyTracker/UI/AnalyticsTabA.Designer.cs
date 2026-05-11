namespace TheGlobalPhilanthropyTracker.UI
{
    partial class AnalyticsTabA
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
            btnTopSector = new Button();
            btnInactive = new Button();
            btnTopContributor = new Button();
            lblStatus = new Label();
            dgvMainOutput = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMainOutput).BeginInit();
            SuspendLayout();
            // 
            // btnTopSector
            // 
            btnTopSector.Location = new Point(12, 12);
            btnTopSector.Name = "btnTopSector";
            btnTopSector.Size = new Size(228, 45);
            btnTopSector.TabIndex = 0;
            btnTopSector.Text = "🏆 Show Top Sector";
            btnTopSector.Click += btnTopSector_Click;
            // 
            // btnInactive
            // 
            btnInactive.Anchor = AnchorStyles.Top;
            btnInactive.Location = new Point(271, 12);
            btnInactive.Name = "btnInactive";
            btnInactive.Size = new Size(225, 45);
            btnInactive.TabIndex = 1;
            btnInactive.Text = "💤 Inactive Initiatives";
            btnInactive.Click += btnInactive_Click;
            // 
            // btnTopContributor
            // 
            btnTopContributor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTopContributor.Location = new Point(530, 12);
            btnTopContributor.Name = "btnTopContributor";
            btnTopContributor.Size = new Size(215, 45);
            btnTopContributor.TabIndex = 2;
            btnTopContributor.Text = "💰 Top Contributor";
            btnTopContributor.Click += btnTopContributor_Click;
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
            // AnalyticsTabA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTopSector);
            Controls.Add(btnInactive);
            Controls.Add(btnTopContributor);
            Controls.Add(lblStatus);
            Controls.Add(dgvMainOutput);
            Name = "AnalyticsTabA";
            Size = new Size(780, 419);
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

