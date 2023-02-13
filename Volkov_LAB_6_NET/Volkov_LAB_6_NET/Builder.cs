using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Builder : Human
    {
        private string builds;

        public Builder()
        {
            builds = string.Empty;
        }

        public Builder(string name, int age, string builds) : base(name, age)
        {
            this.builds = builds;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter what you are building");
            builds = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"Builds -> {builds}\n";
        }
    }
}
