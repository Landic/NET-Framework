using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_26_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> list = new List<Device>()
            {
                new Device("IPhone X", "Apple", 499),
                new Device("IPhone 14 Pro", "Apple", 1000),
                new Device("Strix", "Asus", 1200)
            };
            List<Device> list2 = new List<Device>()
            {
                new Device("Tuff Gaming", "Asus", 1000),
                new Device("IPhone 14 Pro", "Apple", 1000),
                new Device("PlayStation 5", "Sony", 499)
            };

            var result = list.Except(list2, new Sort());

            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var result2 = list.Intersect(list2, new Sort());
            foreach(var i in result2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var result3 = list.Union(list2, new Sort());

            foreach(var i in result3)
            {
                Console.WriteLine(i);
            }
        }

        public class Sort : IEqualityComparer<Device>
        {
            public bool Equals(Device x, Device y)
            {
                if (x.Name == y.Name)
                {
                    return true;
                }
                return false;
            }
            public int GetHashCode(Device obj)
            {
                return obj.Name.GetHashCode();
            }
        }
    }
}
