using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_17_NET
{
    internal class PrintCheck : ICheck
    {
        public void CheckType()
        {
            Console.WriteLine("Print check...");
            //Console.WriteLine(
            //    " ----------- \n" +
            //    "|           |" +
            //    "|   Check   |" +
            //    "|-----------|" +
            //    "|information|\n");
        }
    }
}
