using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Models
{
    public class Vendors
    {
        public int vendorId;
        public string companyName = "";
        public string contactNumber = "";
        //name & number strings will never be null,
        //they start empty to prevent setting them to null by default.
    }
}
