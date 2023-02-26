using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_18_NET
{
    internal class Programmer : IFaculty
    {
        public string Name
        {
            get; set;
        }

        public List<IDepartment> departments { get; set; }

        public List<Student> students { get; set; }

        public void ChooseFaculty()
        {
            Name = "Programmer";
        }
    }
}
