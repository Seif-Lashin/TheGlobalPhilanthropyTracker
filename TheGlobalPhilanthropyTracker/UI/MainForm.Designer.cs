namespace TheGlobalPhilanthropyTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            initiativeTab = new TheGlobalPhilanthropyTracker.UI.InitiativeTab();
            tabPage2 = new TabPage();
            supporterTab = new TheGlobalPhilanthropyTracker.UI.SupporterTab();
            tabPage3 = new TabPage();
            financeTab = new TheGlobalPhilanthropyTracker.UI.FinanceTab();
            tabPage4 = new TabPage();
            analyticsTaba = new TheGlobalPhilanthropyTracker.UI.AnalyticsTabA();
            tabPage5 = new TabPage();
            analyticsTabb = new TheGlobalPhilanthropyTracker.UI.AnalyticsTabB();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(-2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 447);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(initiativeTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Initiative Tab";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // initiativeTab
            // 
            initiativeTab.Dock = DockStyle.Fill;
            initiativeTab.Location = new Point(3, 3);
            initiativeTab.Name = "initiativeTab";
            initiativeTab.Size = new Size(787, 413);
            initiativeTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(supporterTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Supporter Tab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // supporterTab
            // 
            supporterTab.Dock = DockStyle.Fill;
            supporterTab.Location = new Point(3, 3);
            supporterTab.Name = "supporterTab";
            supporterTab.Size = new Size(787, 413);
            supporterTab.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(financeTab);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(793, 419);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Finance Tab";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // financeTab
            // 
            financeTab.Dock = DockStyle.Fill;
            financeTab.Location = new Point(0, 0);
            financeTab.Name = "financeTab";
            financeTab.Size = new Size(793, 419);
            financeTab.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(analyticsTaba);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(793, 419);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Analytics Tab A";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // analyticsTaba
            // 
            analyticsTaba.Dock = DockStyle.Fill;
            analyticsTaba.Location = new Point(0, 0);
            analyticsTaba.Name = "analyticsTaba";
            analyticsTaba.Size = new Size(793, 419);
            analyticsTaba.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(analyticsTabb);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(793, 419);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Analytics Tab B";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // analyticsTabb
            // 
            analyticsTabb.Dock = DockStyle.Fill;
            analyticsTabb.Location = new Point(0, 0);
            analyticsTabb.Name = "analyticsTabb";
            analyticsTabb.Size = new Size(793, 419);
            analyticsTabb.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private UI.SupporterTab supporterTab;
        private UI.FinanceTab financeTab;
        private UI.AnalyticsTabB analyticsTabb;
        private UI.AnalyticsTabA analyticsTaba;
        private UI.InitiativeTab initiativeTab;
    }
}
