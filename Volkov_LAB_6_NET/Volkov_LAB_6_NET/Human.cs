using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Human
    {
        protected string name;
        protected int age;

        public Human()
        {
            name = string.Empty;
            age = 0;
        }

        public Human(string name, int age)
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

        public override string ToString()
        {
            return $"Name -> {name}\tAge -> {age}\t";
        }
    }
}
