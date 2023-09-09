using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Security : Worker
    {
        private string place_for_protection;

        public Security()
        {
            place_for_protection = string.Empty;
        }

        public Security(string name, int age, string place_for_protection) : base(name, age)
        {
            this.place_for_protection = place_for_protection;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter place for protection");
            place_for_protection = Console.ReadLine();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Place for protection -> {place_for_protection}");
        }
    }
}
