using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_22_NET
{
    internal class ReportTheame : IReport
    {
        public string report
        {
            get; set;
        }

        public string Report(List<Poem> poems)
        {
            foreach(Poem poem in poems)
            {
                report += "Theame -> " + poem.TheamPoem + "\n";
            }
            return report;
        }
    }
}
