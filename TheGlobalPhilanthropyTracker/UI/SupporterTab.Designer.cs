namespace TheGlobalPhilanthropyTracker.UI
{
    partial class SupporterTab
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
            ((System.ComponentModel.ISupportInitialize)dgvSupporters).BeginInit();
            SuspendLayout();
            // 
            // dgvSupporters
            // 
            dgvSupporters.BackgroundColor = Color.FromArgb(45, 45, 48);
            dgvSupporters.BorderStyle = BorderStyle.None;
            dgvSupporters.Location = new Point(20, 20);
            dgvSupporters.Name = "dgvSupporters";
            dgvSupporters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupporters.Size = new Size(1140, 240);
            dgvSupporters.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 300);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(130, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(170, 300);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(130, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(320, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(45, 45, 48);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(20, 340);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 30);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdateEmail
            // 
            btnUpdateEmail.BackColor = Color.FromArgb(45, 45, 48);
            btnUpdateEmail.FlatAppearance.BorderSize = 0;
            btnUpdateEmail.FlatStyle = FlatStyle.Flat;
            btnUpdateEmail.Location = new Point(130, 340);
            btnUpdateEmail.Name = "btnUpdateEmail";
            btnUpdateEmail.Size = new Size(100, 30);
            btnUpdateEmail.TabIndex = 5;
            btnUpdateEmail.Text = "Update Email";
            btnUpdateEmail.UseVisualStyleBackColor = false;
            btnUpdateEmail.Click += btnUpdateEmail_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(180, 50, 50);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(1030, 340);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 30);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove Supporter";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbInitiative
            // 
            cmbInitiative.FormattingEnabled = true;
            cmbInitiative.Location = new Point(600, 300);
            cmbInitiative.Name = "cmbInitiative";
            cmbInitiative.Size = new Size(150, 23);
            cmbInitiative.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(770, 300);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 8;
            // 
            // btnSubmitContribution
            // 
            btnSubmitContribution.BackColor = Color.FromArgb(45, 45, 48);
            btnSubmitContribution.FlatAppearance.BorderSize = 0;
            btnSubmitContribution.FlatStyle = FlatStyle.Flat;
            btnSubmitContribution.Location = new Point(600, 340);
            btnSubmitContribution.Name = "btnSubmitContribution";
            btnSubmitContribution.Size = new Size(130, 30);
            btnSubmitContribution.TabIndex = 9;
            btnSubmitContribution.Text = "Submit Contribution";
            btnSubmitContribution.UseVisualStyleBackColor = false;
            btnSubmitContribution.Click += btnSubmitContribution_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 280);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(170, 280);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(320, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblInitiative
            // 
            lblInitiative.AutoSize = true;
            lblInitiative.Location = new Point(600, 280);
            lblInitiative.Name = "lblInitiative";
            lblInitiative.Size = new Size(86, 15);
            lblInitiative.TabIndex = 3;
            lblInitiative.Text = "Select Initiative";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(770, 280);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount";
            // 
            // SupporterTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblEmail);
            Controls.Add(lblInitiative);
            Controls.Add(lblAmount);
            Controls.Add(btnSubmitContribution);
            Controls.Add(txtAmount);
            Controls.Add(cmbInitiative);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdateEmail);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dgvSupporters);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "SupporterTab";
            Size = new Size(1185, 500);
            ((System.ComponentModel.ISupportInitialize)dgvSupporters).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}