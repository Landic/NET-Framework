using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Music trombone");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");

        public override void History() => Console.WriteLine("The appearance of the trombone dates back to the 15th century.");
    }
}
