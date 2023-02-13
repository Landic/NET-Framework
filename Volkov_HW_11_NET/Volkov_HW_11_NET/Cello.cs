using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Cello : MusicalInstrument
    {
        public Cello(string name, string characteristic) : base(name, characteristic) { }

        public override void Sound() => Console.WriteLine("Music cello");

        public override void Show() => Console.WriteLine($"Name -> {name}");

        public override void Desc() => Console.WriteLine($"Desc -> {characteristic}");

        public override void History() => Console.WriteLine("The appearance of the cello dates back to the late 15th and early 16th centuries as a result of a long development of folk bowed instruments.");
    }
}
