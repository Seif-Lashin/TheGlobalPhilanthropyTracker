namespace TheGlobalPhilanthropyTracker.UI.InitiativeTabUtils
{
    partial class CreateEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            tbObjective = new TextBox();
            tbTitle = new TextBox();
            tbSummary = new TextBox();
            label4 = new Label();
            numericUpDownTarget = new NumericUpDown();
            label5 = new Label();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cbSector = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            lbID = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarget).BeginInit();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeader.Location = new Point(12, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(769, 47);
            lbHeader.TabIndex = 10;
            lbHeader.Text = "Add Initiative";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 102);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 97);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Primary Objective";
            // 
            // tbObjective
            // 
            tbObjective.Location = new Point(516, 94);
            tbObjective.Multiline = true;
            tbObjective.Name = "tbObjective";
            tbObjective.ScrollBars = ScrollBars.Vertical;
            tbObjective.Size = new Size(211, 63);
            tbObjective.TabIndex = 6;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(158, 94);
            tbTitle.MaxLength = 100;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(211, 23);
            tbTitle.TabIndex = 1;
            // 
            // tbSummary
            // 
            tbSummary.Location = new Point(516, 184);
            tbSummary.Multiline = true;
            tbSummary.Name = "tbSummary";
            tbSummary.ScrollBars = ScrollBars.Vertical;
            tbSummary.Size = new Size(211, 63);
            tbSummary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 184);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Impact Summary";
            // 
            // numericUpDownTarget
            // 
            numericUpDownTarget.DecimalPlaces = 2;
            numericUpDownTarget.Location = new Point(158, 126);
            numericUpDownTarget.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownTarget.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTarget.Name = "numericUpDownTarget";
            numericUpDownTarget.Size = new Size(211, 23);
            numericUpDownTarget.TabIndex = 2;
            numericUpDownTarget.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 128);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 11;
            label5.Text = "Funding Target";
            // 
            // dtStart
            // 
            dtStart.Format = DateTimePickerFormat.Short;
            dtStart.Location = new Point(158, 155);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(211, 23);
            dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            dtEnd.Format = DateTimePickerFormat.Short;
            dtEnd.Location = new Point(158, 184);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(211, 23);
            dtEnd.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 161);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 190);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 15;
            label7.Text = "End Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(285, 275);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(423, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbSector
            // 
            cbSector.FormattingEnabled = true;
            cbSector.Location = new Point(158, 213);
            cbSector.Name = "cbSector";
            cbSector.Size = new Size(211, 23);
            cbSector.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 216);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 19;
            label8.Text = "Sector";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 66);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 20;
            label3.Text = "ID";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(158, 66);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 21;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 340);
            Controls.Add(lbID);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(cbSector);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Controls.Add(label5);
            Controls.Add(numericUpDownTarget);
            Controls.Add(tbSummary);
            Controls.Add(label4);
            Controls.Add(tbTitle);
            Controls.Add(tbObjective);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbHeader);
            Name = "CreateEditForm";
            Text = "Add Initiative";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label label1;
        private Label label2;
        private TextBox tbObjective;
        private TextBox tbTitle;
        private TextBox tbSummary;
        private Label label4;
        private NumericUpDown numericUpDownTarget;
        private Label label5;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbSector;
        private Label label8;
        private Label label3;
        private Label lbID;
    }
}