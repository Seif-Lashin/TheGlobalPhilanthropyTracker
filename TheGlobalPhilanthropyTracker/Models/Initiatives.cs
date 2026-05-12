using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Initiatives
    {
        public int initiativeId { get; set; }
        public int sectorId { get; set; }
        public string title { get; set; } = "";
        public string? primaryObjective { get; set; }
        public decimal? fundingTarget { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string? impactSummaries { get; set; }
    }
}
