using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Input();
            obj.Output();
            obj[0] = "Barak";
            obj[1] = "Obama";
            obj[2] = "J";
            obj.Email = "kartoshka@gmail.com";
            obj.Birthday = "01.01.2001";
            obj.Phone = "+3805738575";
            obj.JobResponsibilities = "Gotovit edy";
            obj.JobTitle = "Povar";
            obj.Output();
        }
    }
}
