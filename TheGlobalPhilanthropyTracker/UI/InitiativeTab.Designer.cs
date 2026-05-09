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
            ((System.ComponentModel.ISupportInitialize)initiativesTable).BeginInit();
            SuspendLayout();
            // 
            // initiativesTable
            // 
            initiativesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            initiativesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            initiativesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            initiativesTable.Location = new Point(3, 349);
            initiativesTable.MultiSelect = false;
            initiativesTable.Name = "initiativesTable";
            initiativesTable.RowHeadersVisible = false;
            initiativesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            initiativesTable.Size = new Size(1325, 276);
            initiativesTable.TabIndex = 0;
            // 
            // InitiativeTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(initiativesTable);
            Name = "InitiativeTab";
            Size = new Size(1331, 628);
            ((System.ComponentModel.ISupportInitialize)initiativesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView initiativesTable;
    }
}
