using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Contributions
    {
        public int UniqueReference { get; set; }
        public int SupporterId { get; set; }
        public int InitiativeId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
