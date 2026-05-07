using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheGlobalPhilanthropyTracker.UI
{
    public partial class InitiativeTab : UserControl
    {
        public InitiativeTab()
        {
            InitializeComponent();

            this.label1.Text = "Initiative Data Loaded at " + DateTime.Now.ToShortTimeString();
        }
    }
}
