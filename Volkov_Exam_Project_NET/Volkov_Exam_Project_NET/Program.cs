using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Exam_Project_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Word> obj2 = new List<Word>();
            MyDictionary obj = new MyDictionary(new EngRus(),obj2);
            obj.Add2();
            obj.Output();
        }
    }
}
