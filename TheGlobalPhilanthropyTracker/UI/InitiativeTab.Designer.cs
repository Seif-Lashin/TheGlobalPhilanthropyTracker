namespace TheGlobalPhilanthropyTracker.UI
{
    partial class InitiativeTab
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
            initiativesTable = new DataGridView();
            label1 = new Label();
            btnAddInitiative = new Button();
            btnEditInitiative = new Button();
            btnDeleteInitiative = new Button();
            gbSummary = new GroupBox();
            rtbSummary = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)initiativesTable).BeginInit();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // initiativesTable
            // 
            initiativesTable.AllowUserToAddRows = false;
            initiativesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            initiativesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            initiativesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            initiativesTable.Location = new Point(3, 349);
            initiativesTable.MultiSelect = false;
            initiativesTable.Name = "initiativesTable";
            initiativesTable.ReadOnly = true;
            initiativesTable.RowHeadersVisible = false;
            initiativesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            initiativesTable.Size = new Size(816, 258);
            initiativesTable.TabIndex = 0;
            initiativesTable.SelectionChanged += initiativesTable_SelectionChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(819, 61);
            label1.TabIndex = 1;
            label1.Text = "Initiatives";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddInitiative
            // 
            btnAddInitiative.Location = new Point(20, 320);
            btnAddInitiative.Name = "btnAddInitiative";
            btnAddInitiative.Size = new Size(143, 23);
            btnAddInitiative.TabIndex = 2;
            btnAddInitiative.Text = "Add Initiative";
            btnAddInitiative.UseVisualStyleBackColor = true;
            btnAddInitiative.Click += btnAddInitiative_Click;
            // 
            // btnEditInitiative
            // 
            btnEditInitiative.Location = new Point(169, 320);
            btnEditInitiative.Name = "btnEditInitiative";
            btnEditInitiative.Size = new Size(143, 23);
            btnEditInitiative.TabIndex = 3;
            btnEditInitiative.Text = "Edit Initiative";
            btnEditInitiative.UseVisualStyleBackColor = true;
            btnEditInitiative.Click += btnEditInitiative_Click;
            // 
            // btnDeleteInitiative
            // 
            btnDeleteInitiative.Location = new Point(318, 320);
            btnDeleteInitiative.Name = "btnDeleteInitiative";
            btnDeleteInitiative.Size = new Size(143, 23);
            btnDeleteInitiative.TabIndex = 4;
            btnDeleteInitiative.Text = "Delete Initiative";
            btnDeleteInitiative.UseVisualStyleBackColor = true;
            btnDeleteInitiative.Click += btnDeleteInitiative_Click;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(rtbSummary);
            gbSummary.Location = new Point(20, 107);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(788, 177);
            gbSummary.TabIndex = 5;
            gbSummary.TabStop = false;
            gbSummary.Text = "Impact Summary";
            // 
            // rtbSummary
            // 
            rtbSummary.Location = new Point(523, 14);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.ReadOnly = true;
            rtbSummary.Size = new Size(259, 157);
            rtbSummary.TabIndex = 0;
            rtbSummary.Text = "";
            // 
            // InitiativeTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbSummary);
            Controls.Add(btnDeleteInitiative);
            Controls.Add(btnEditInitiative);
            Controls.Add(btnAddInitiative);
            Controls.Add(label1);
            Controls.Add(initiativesTable);
            Name = "InitiativeTab";
            Size = new Size(822, 610);
            ((System.ComponentModel.ISupportInitialize)initiativesTable).EndInit();
            gbSummary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView initiativesTable;
        private Label label1;
        private Button btnAddInitiative;
        private Button btnEditInitiative;
        private Button btnDeleteInitiative;
        private GroupBox gbSummary;
        private RichTextBox rtbSummary;
    }
}
