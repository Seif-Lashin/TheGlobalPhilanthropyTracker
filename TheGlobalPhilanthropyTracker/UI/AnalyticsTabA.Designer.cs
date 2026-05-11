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
            btnTopSector.Location = new Point(14, 16);
            btnTopSector.Margin = new Padding(3, 4, 3, 4);
            btnTopSector.Name = "btnTopSector";
            btnTopSector.Size = new Size(260, 60);
            btnTopSector.TabIndex = 0;
            btnTopSector.Text = "🏆 Show Top Sector";
            btnTopSector.Click += btnTopSector_Click;
            // 
            // btnInactive
            // 
            btnInactive.Location = new Point(310, 16);
            btnInactive.Margin = new Padding(3, 4, 3, 4);
            btnInactive.Name = "btnInactive";
            btnInactive.Size = new Size(257, 60);
            btnInactive.TabIndex = 1;
            btnInactive.Text = "💤 Inactive Initiatives";
            btnInactive.Click += btnInactive_Click;
            // 
            // btnTopContributor
            // 
            btnTopContributor.Location = new Point(606, 16);
            btnTopContributor.Margin = new Padding(3, 4, 3, 4);
            btnTopContributor.Name = "btnTopContributor";
            btnTopContributor.Size = new Size(246, 60);
            btnTopContributor.TabIndex = 2;
            btnTopContributor.Text = "💰 Top Contributor";
            btnTopContributor.Click += btnTopContributor_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(14, 87);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(857, 27);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Click a button above to load data.";
            // 
            // dgvMainOutput
            // 
            dgvMainOutput.AllowUserToAddRows = false;
            dgvMainOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainOutput.BackgroundColor = SystemColors.Window;
            dgvMainOutput.ColumnHeadersHeight = 29;
            dgvMainOutput.Location = new Point(14, 130);
            dgvMainOutput.Margin = new Padding(3, 4, 3, 4);
            dgvMainOutput.Name = "dgvMainOutput";
            dgvMainOutput.ReadOnly = true;
            dgvMainOutput.RowHeadersWidth = 51;
            dgvMainOutput.Size = new Size(857, 400);
            dgvMainOutput.TabIndex = 4;
            // 
            // AnalyticsTabA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTopSector);
            Controls.Add(btnInactive);
            Controls.Add(btnTopContributor);
            Controls.Add(lblStatus);
            Controls.Add(dgvMainOutput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnalyticsTabA";
            Size = new Size(1431, 559);
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

