using System;
using System.Collections.Generic;

namespace Home_Renovation_Budget.Models
{
    public class Appliance
    {
        public Guid ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public DateTime Supplier { get; set; }

        public ICollection<Price> Prices { get; set; }
    }
}