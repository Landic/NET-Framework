using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Sailor : Human
    {
        private string ocean;

        public Sailor() 
        { 
            ocean = string.Empty; 
        }

        public Sailor(string name, int age, string ocean) : base(name, age)
        {
            this.ocean = ocean;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter which ocean you are sailing in");
            ocean = Console.ReadLine(); 
        }

        public override string ToString()
        {
            return base.ToString() + $"Ocean -> {ocean}\n";
        }
    }
}
