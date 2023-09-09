﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_22_NET
{
    internal class ReportCountText : IReport
    {
        public string report
        {
            get; set;
        }

        string IReport.Report(List<Poem> poems)
        {
            int i = 0;
            foreach (Poem poem in poems)
            {
                i = poem.TextPoem.Count();
            }
            report += i;
            return report;
        }
    }
}
