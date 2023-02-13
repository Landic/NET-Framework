using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Steamer : Device
    {
        public Steamer(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Bulk");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");
    }
}
