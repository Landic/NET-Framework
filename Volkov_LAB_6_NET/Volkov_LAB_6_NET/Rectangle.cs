using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Rectangle : Figure
    {
        private double a;
        private double b;

        public Rectangle()
        {
            a = 0;
            b = 0;
        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Square()
        {
            return a * b;
        }
    }
}
