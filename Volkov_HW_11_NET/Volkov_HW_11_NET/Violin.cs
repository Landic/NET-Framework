using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Violin : MusicalInstrument
    {
        public Violin(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Music violin");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");

        public override void History() => Console.WriteLine("The progenitors of the violin were the Arabic rebab, the Spanish fidel, the German company, the merger of which formed the viola.");
    }
}
