using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Animal
    {
        protected string name;
        protected string characteristics;

        public Animal()
        {
            name = string.Empty;
            characteristics = string.Empty;
        }

        public Animal(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter characteristics");
            characteristics = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name -> {name}\nCharacteristics -> {characteristics}\n";
        }
    }
}
