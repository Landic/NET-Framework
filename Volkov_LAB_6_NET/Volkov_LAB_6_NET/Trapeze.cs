using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Trapeze : Figure
    {
        private double m;
        private double h;

        public Trapeze()
        {
            m = 0;
            h = 0;
        }

        public Trapeze(double m, double h)
        {
            this.m = m;
            this.h = h;
        }

        public override double Square()
        {
            return m * h;
        }
    }
}
