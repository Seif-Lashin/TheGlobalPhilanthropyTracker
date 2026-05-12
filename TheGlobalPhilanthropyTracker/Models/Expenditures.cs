using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Expenditures
    {
        public int itemID { get; set; }
        public int initiativeId { get; set; }
        public int vendorId { get; set; }
        public decimal? amountSpent { get; set; }
        public DateTime? dateSpent { get; set; }
    }
}
