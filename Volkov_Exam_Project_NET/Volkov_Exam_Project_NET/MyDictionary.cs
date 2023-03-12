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
        public string Type { get; set; }

        public Dictionary<string, List<string>> dictionary { get; set; }

        public MyDictionary(IType type)
        {
            Type = type.Type();
            dictionary = new Dictionary<string, List<string>>();
        }

        public void AddDictionary()
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            Console.WriteLine("Enter translation");
            string translation1 = Console.ReadLine();
            string[] translation2 = translation1.Split(' ');
            List<string> list = new List<string>(translation2.Select(t => t.Trim()));
            dictionary.Add(word, list);
        }

        public void GetAllDictionary()
        {
            Console.WriteLine($"Dictionary - count word {dictionary.Keys.Count}, type - {Type}");
        }

        public void Output()
        {
            foreach (KeyValuePair<string, List<string>> i in dictionary)
            {
                Console.WriteLine($"{i.Key} - {string.Join(" ", i.Value)}");
            }
        }
    }
}
