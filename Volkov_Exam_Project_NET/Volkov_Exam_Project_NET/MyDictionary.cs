using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Volkov_Exam_Project_NET
{
    internal class MyDictionary
    {
        public string Type { get; set; } // хранит тип словаря

        public Dictionary<string, List<string>> dictionary { get; set; } // хранилище слов и переводов

        public MyDictionary(IType type)
        {
            Type = type.Type();
            dictionary = new Dictionary<string, List<string>>();
        }

        public void GetAllDictionary() // Получение всех существующих словарей и сколько в них слов и какой тип
        {
            Console.WriteLine($"Dictionary - count word {dictionary.Keys.Count}, type - {Type}");
        }
    }
}
