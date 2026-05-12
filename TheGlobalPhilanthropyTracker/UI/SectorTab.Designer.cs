namespace TheGlobalPhilanthropyTracker.UI
{
    partial class SectorTab
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
            sectorsTable = new DataGridView();
            label1 = new Label();
            btnAddSector = new Button();
            btnEditSector = new Button();
            btnDeleteSector = new Button();
            ((System.ComponentModel.ISupportInitialize)sectorsTable).BeginInit();
            SuspendLayout();
            // 
            // sectorsTable
            // 
            sectorsTable.AllowUserToAddRows = false;
            sectorsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sectorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sectorsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sectorsTable.Location = new Point(3, 349);
            sectorsTable.MultiSelect = false;
            sectorsTable.Name = "sectorsTable";
            sectorsTable.ReadOnly = true;
            sectorsTable.RowHeadersVisible = false;
            sectorsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sectorsTable.Size = new Size(1310, 276);
            sectorsTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1313, 61);
            label1.TabIndex = 1;
            label1.Text = "Sectors";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddSector
            // 
            btnAddSector.Location = new Point(16, 320);
            btnAddSector.Name = "btnAddSector";
            btnAddSector.Size = new Size(143, 23);
            btnAddSector.TabIndex = 2;
            btnAddSector.Text = "Add Sector";
            btnAddSector.UseVisualStyleBackColor = true;
            btnAddSector.Click += btnAddSector_Click;
            // 
            // btnEditSector
            // 
            btnEditSector.Location = new Point(165, 320);
            btnEditSector.Name = "btnEditSector";
            btnEditSector.Size = new Size(143, 23);
            btnEditSector.TabIndex = 3;
            btnEditSector.Text = "Edit Sector";
            btnEditSector.UseVisualStyleBackColor = true;
            btnEditSector.Click += btnEditSector_Click;
            // 
            // btnDeleteSector
            // 
            btnDeleteSector.Location = new Point(314, 320);
            btnDeleteSector.Name = "btnDeleteSector";
            btnDeleteSector.Size = new Size(143, 23);
            btnDeleteSector.TabIndex = 4;
            btnDeleteSector.Text = "Delete Sector";
            btnDeleteSector.UseVisualStyleBackColor = true;
            btnDeleteSector.Click += btnDeleteSector_Click;
            // 
            // SectorTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteSector);
            Controls.Add(btnEditSector);
            Controls.Add(btnAddSector);
            Controls.Add(label1);
            Controls.Add(sectorsTable);
            Name = "SectorTab";
            Size = new Size(1316, 628);
            ((System.ComponentModel.ISupportInitialize)sectorsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView sectorsTable;
        private Label label1;
        private Button btnAddSector;
        private Button btnEditSector;
        private Button btnDeleteSector;
    }
}
