using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_11_NET
{
    internal class Product
    {
        Money obj;

        public Product()
        {
            obj = new Money();
            obj.Copeck = 0;
            obj.Bills = 0;
        }
        public Product(Money obj) 
        {
            this.obj = obj;
        }

        public override string ToString()
        {
            return $"Price -> {obj.Bills}.{obj.Copeck}";
        }

        public static Product operator -(Product a, int b)
        {
            Product result = new Product();
            if(a.obj.Bills > b || a.obj.Copeck == b)
            {
                result.obj.Bills = a.obj.Bills - b;
            }
            else
            {
                result.obj.Copeck = a.obj.Copeck - b;
            }
            return result;
        }
    }
}
