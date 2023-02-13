using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class MusicalInstrument
    {
        protected string name;
        protected string characteristic;

        public MusicalInstrument()
        {
            name = string.Empty;
            characteristic = string.Empty;
        }

        public MusicalInstrument(string name, string characteristic)
        {
            this.name = name;
            this.characteristic = characteristic;
        }

        public override string ToString()
        {
            return $"Name -> {name}\tCharacteristic -> {characteristic}";
        }

        public virtual void Sound() => Console.WriteLine("No sound");
        public virtual void Show() => Console.WriteLine($"Name device -> {name}");

        public virtual void Desc() => Console.WriteLine($"Desc -> {characteristic}");

        public virtual void History() => Console.WriteLine("No history");
    }
}
