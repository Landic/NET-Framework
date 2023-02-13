using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Volkov_HW_11_NET
{
    internal class Car : Device
    {
        public Car(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Vrum v stolb");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");
    }
}
