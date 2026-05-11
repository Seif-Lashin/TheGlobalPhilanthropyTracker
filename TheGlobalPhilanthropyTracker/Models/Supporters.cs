using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Supporters
    {
        public int SupporterId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
