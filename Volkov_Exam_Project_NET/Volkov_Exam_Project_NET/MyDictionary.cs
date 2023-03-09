using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Volkov_Exam_Project_NET
{
    internal class MyDictionary
    {
        List<Word> words;

        public MyDictionary(IType type, List<Word> words)
        {
            type.Type();
            words = new List<Word>();
        }

        public void Add2()
        {
            Console.Write("Введите слово: ");
            string term = Console.ReadLine();

            Console.Write("Введите переводы через запятую: ");
            string[] translationsArray = Console.ReadLine().Split(',');
            List<string> translations = new List<string>(translationsArray.Select(t => t.Trim()));

            Word word = new Word(term, translations);
        }

        public void Output()
        {
            foreach (Word word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
