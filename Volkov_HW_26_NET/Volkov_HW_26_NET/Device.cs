using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_26_NET
{
    internal class Device
    {
        public string Name { get; set; }
        public string Firm { get; set; }
        public double Price { get; set; }

        public Device()
        {
            Name = string.Empty;
            Firm = string.Empty;
            Price = 0;
        }

        public Device(string name, string firm, double price)
        {
            Name = name;
            Firm = firm;
            Price = price;
        }

        public override string ToString() { return $"Device -> {Name}\nFirm -> {Firm}\nPrice -> {Price}"; }
    }
}
