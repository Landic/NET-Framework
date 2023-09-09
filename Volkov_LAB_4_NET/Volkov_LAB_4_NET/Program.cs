using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_4_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit_Card obj = new Credit_Card();
            try
            {
                obj.Init();
                Console.WriteLine(obj.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
