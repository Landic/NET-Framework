using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Device
    {
        protected string name;
        protected string characteristic;
        
        public Device()
        {
            name = string.Empty;
            characteristic = string.Empty;
        }

        public Device(string name, string characteristic)
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
    }
}
