using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Music ukulele");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");

        public override void History() => Console.WriteLine("The ukulele appeared in the Hawaiian Islands in the second half of the 19th century.");
    }
}
