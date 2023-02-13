using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Pilot : Human
    {
        private string direction;

        public Pilot()
        {
            direction = string.Empty;
        }

        public Pilot(string name, int age, string direction) : base(name, age)
        {
            this.direction = direction;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter direction");
            direction = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"Direction -> {direction}\n";
        }
    }
}
