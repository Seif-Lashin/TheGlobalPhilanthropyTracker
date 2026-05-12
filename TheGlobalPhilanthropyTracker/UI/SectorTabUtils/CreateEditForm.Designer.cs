namespace TheGlobalPhilanthropyTracker.UI.SectorTabUtils
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
            label3 = new Label();
            lbID = new Label();
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
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
            lbHeader.Text = "Add Sector";
            lbHeader.TextAlign = ContentAlignment.MiddleCenter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 102);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(158, 99);
            tbName.MaxLength = 50;
            tbName.Name = "tbName";
            tbName.Size = new Size(211, 23);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 135);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(158, 132);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(211, 63);
            tbDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(285, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(423, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 270);
            Controls.Add(lbID);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbDescription);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(lbHeader);
            Name = "CreateEditForm";
            Text = "Add Sector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label label3;
        private Label lbID;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}