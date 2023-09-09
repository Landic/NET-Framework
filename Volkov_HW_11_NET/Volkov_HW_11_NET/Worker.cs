using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal abstract class Worker
    {
        protected string name;
        protected int age;

        public Worker()
        {
            name = string.Empty;
            age = 0;
        }

        public Worker(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name -> {name}");
            Console.WriteLine($"Age -> {age}");
        }
    }
}
