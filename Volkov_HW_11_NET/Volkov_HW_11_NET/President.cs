using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class President : Worker
    {
        private int presidency_term;

        public President()
        {
            presidency_term = 0;
        }

        public President(string name, int age,int presidency_term) : base(name, age)
        {
            this.presidency_term = presidency_term;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter presidency term");
            presidency_term = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Presidency term -> {presidency_term}");
        }
    }
}
