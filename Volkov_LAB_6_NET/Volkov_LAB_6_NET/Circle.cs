using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Circle : Figure
    {
        private double r;

        public Circle()
        {
            r = 0;
        }

        public Circle(double r)
        {
            this.r = r;
        }

        public override double Square()
        {
            return Math.Pow(r,2) * 3.14;
        }
    }
}
