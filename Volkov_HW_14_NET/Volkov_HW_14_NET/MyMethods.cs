using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_14_NET
{
    internal class MyMethods
    {
        private double x, y;

        public MyMethods()
        {
            x = 0;
            y = 0;
        }

        public MyMethods(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void TimeNow()
        {
            DateTime date= DateTime.Now;
            Console.WriteLine(date.ToString("h:mm:ss tt"));
        }

        public void DateNow()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
        }

        public void DayWeekNow()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek);
        }

        public void SquareTriangle()
        {
            double square = 0;
            square = 1.2 * (x * y);
            Console.WriteLine("Square triangle -> " + square);
        }

        public void SquareRecrangle()
        {
            double square = 0;
            square = x * y;
            Console.WriteLine("Square rectangle -> " + square);
            
        }


    }
}
