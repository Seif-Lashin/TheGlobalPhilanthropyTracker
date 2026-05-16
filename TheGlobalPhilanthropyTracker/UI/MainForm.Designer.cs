namespace TheGlobalPhilanthropyTracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            tabPage6 = new TabPage();
            sectorTab1 = new TheGlobalPhilanthropyTracker.UI.SectorTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();

            // ── tabControl1 ──────────────────────────────────────
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1280, 720);
            tabControl1.TabIndex = 0;
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            tabControl1.Padding = new Point(20, 8);

            // ── tabPage1 – Initiatives ────────────────────────────
            tabPage1.Controls.Add(initiativeTab);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(0);
            tabPage1.Size = new Size(1272, 686);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "  🎯  Initiatives  ";
            tabPage1.UseVisualStyleBackColor = false;
            tabPage1.BackColor = Color.FromArgb(18, 18, 24);

            initiativeTab.Dock = DockStyle.Fill;
            initiativeTab.Location = new Point(0, 0);
            initiativeTab.Name = "initiativeTab";
            initiativeTab.Size = new Size(1272, 686);
            initiativeTab.TabIndex = 0;

            // ── tabPage2 – Supporters ────────────────────────────
            tabPage2.Controls.Add(supporterTab);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(0);
            tabPage2.Size = new Size(1272, 686);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "  🤝  Supporters  ";
            tabPage2.UseVisualStyleBackColor = false;
            tabPage2.BackColor = Color.FromArgb(18, 18, 24);

            supporterTab.BackColor = Color.FromArgb(18, 18, 24);
            supporterTab.Dock = DockStyle.Fill;
            supporterTab.ForeColor = Color.FromArgb(220, 220, 230);
            supporterTab.Location = new Point(0, 0);
            supporterTab.Name = "supporterTab";
            supporterTab.Size = new Size(1272, 686);
            supporterTab.TabIndex = 0;

            // ── tabPage3 – Finance ───────────────────────────────
            tabPage3.Controls.Add(financeTab);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1272, 686);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "  💰  Finance  ";
            tabPage3.UseVisualStyleBackColor = false;
            tabPage3.BackColor = Color.FromArgb(18, 18, 24);

            financeTab.Dock = DockStyle.Fill;
            financeTab.Location = new Point(0, 0);
            financeTab.Name = "financeTab";
            financeTab.Size = new Size(1272, 686);
            financeTab.TabIndex = 0;

            // ── tabPage4 – Analytics A ───────────────────────────
            tabPage4.Controls.Add(analyticsTaba);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1272, 686);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "  📊  Analytics I  ";
            tabPage4.UseVisualStyleBackColor = false;
            tabPage4.BackColor = Color.FromArgb(18, 18, 24);

            analyticsTaba.Dock = DockStyle.Fill;
            analyticsTaba.Location = new Point(0, 0);
            analyticsTaba.Name = "analyticsTaba";
            analyticsTaba.Size = new Size(1272, 686);
            analyticsTaba.TabIndex = 0;

            // ── tabPage5 – Analytics B ───────────────────────────
            tabPage5.Controls.Add(analyticsTabb);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1272, 686);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "  📈  Analytics II  ";
            tabPage5.UseVisualStyleBackColor = false;
            tabPage5.BackColor = Color.FromArgb(18, 18, 24);

            analyticsTabb.Dock = DockStyle.Fill;
            analyticsTabb.Location = new Point(0, 0);
            analyticsTabb.Name = "analyticsTabb";
            analyticsTabb.Size = new Size(1272, 686);
            analyticsTabb.TabIndex = 0;

            // ── tabPage6 – Sectors ───────────────────────────────
            tabPage6.Controls.Add(sectorTab1);
            tabPage6.Location = new Point(4, 30);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(0);
            tabPage6.Size = new Size(1272, 686);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "  🌐  Sectors  ";
            tabPage6.UseVisualStyleBackColor = false;
            tabPage6.BackColor = Color.FromArgb(18, 18, 24);

            sectorTab1.Dock = DockStyle.Fill;
            sectorTab1.Location = new Point(0, 0);
            sectorTab1.Name = "sectorTab1";
            sectorTab1.Size = new Size(1272, 686);
            sectorTab1.TabIndex = 0;

            // ── MainForm ─────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Global Philanthropy Tracker";
            BackColor = Color.FromArgb(18, 18, 24);
            Font = new Font("Segoe UI", 9.5F);

            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
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
        private TabPage tabPage6;
        private UI.SectorTab sectorTab1;
    }
}