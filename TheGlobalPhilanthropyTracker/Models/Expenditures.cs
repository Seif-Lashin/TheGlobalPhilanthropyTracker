using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Expenditures
    {
        public int itemID;
        public int initiativeId;
        public int vendorId;
        public decimal amountSpent;
        public DateTime dateSpent;
        //{ get;  set; }
    }
}
