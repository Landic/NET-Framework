using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_7_NET
{
    internal interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
}
