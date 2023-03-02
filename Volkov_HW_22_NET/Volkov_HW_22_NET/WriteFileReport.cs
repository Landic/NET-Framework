using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_22_NET
{
    internal class WriteFileReport
    {
        public void Write(IReport rep, string filename)
        {
            using(StreamWriter writer = new StreamWriter(filename+".txt"))
            {
                writer.Write(rep.report);
            }
        }
    }
}
