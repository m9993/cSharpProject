using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.PharmacyManagementSystem.Entity
{
    public class Sale
    {
        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
