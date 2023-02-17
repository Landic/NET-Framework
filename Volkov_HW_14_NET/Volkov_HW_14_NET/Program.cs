using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_14_NET
{
    internal class Program
    {
        private delegate void GetArr();

        private delegate void GetMethods();

        private delegate double GetMethods2(double x,double y);

        static void Func(GetMethods ptr)
        {
            ptr();
        }

        static void Main(string[] args)
        {
            #region task1
            //MyArray obj = new MyArray(10);
            //GetArr del = new GetArr(obj.Even);
            //del += obj.NoEven;
            //del += obj.JustANumber;
            //del += obj.Fibonachi;
            //del.Invoke();
            #endregion
            #region task2
            MyMethods obj = new MyMethods(5.5, 7.8);
            Func(obj.DateNow);
            Func(obj.DayWeekNow);
            Func(obj.TimeNow);
            Func(obj.SquareRecrangle);
            Func(obj.SquareTriangle);
            #endregion 
        }
    }
}
