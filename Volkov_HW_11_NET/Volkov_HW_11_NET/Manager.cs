using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Manager : Worker
    {
        private int opening_hours;

        public Manager()
        {
            opening_hours = 0;
        }

        public Manager(string name, int age, int opening_hours) : base(name, age)
        {
            this.opening_hours = opening_hours;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter place for protection");
            opening_hours = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Opening hours -> {opening_hours}");
        }
    }
}
