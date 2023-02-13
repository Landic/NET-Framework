using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Engineer : Worker
    {
        private string what_fixes;

        public Engineer()
        {
            what_fixes = string.Empty;
        }

        public Engineer(string name, int age, string what_fixes) : base(name, age)
        {
            this.what_fixes = what_fixes;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter what you need to fix");
            what_fixes = Console.ReadLine();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Fix -> {what_fixes}");
        }
    }
}
