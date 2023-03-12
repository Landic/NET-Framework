using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Volkov_Exam_Project_NET
{
    internal interface IReplace
    {
        void MyReplace(MyDictionary dict);
    }

    internal class ReplaceWord : IReplace
    {
        public void MyReplace(MyDictionary dict)
        {
            Console.WriteLine("Enter a replacement word");
            string wordreplace = Console.ReadLine();
            Console.WriteLine("Enter a new word");
            string wordnew = Console.ReadLine();
            if (dict.dictionary.ContainsKey(wordreplace))
            {
                List<string> value = dict.dictionary[wordreplace];
                dict.dictionary.Remove(wordreplace);
                dict.dictionary.Add(wordnew, value);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" -----------------------\n" +
                                  "| There is no such word |\n" +
                                  " -----------------------");
                Thread.Sleep(500);
                Console.ResetColor();
            }
        }
    }

    internal class ReplaceTranslation : IReplace
    {
        public void MyReplace(MyDictionary dict)
        {
            Console.WriteLine("Enter word");
            string key = Console.ReadLine();
            Console.WriteLine("Enter translation to replace");
            string translation = Console.ReadLine();
            Console.WriteLine("Enter new translation");
            string newtranslation = Console.ReadLine();
            List<string> translation2 = dict.dictionary[key];
            int index = translation2.IndexOf(translation);
            if (index >= 0)
            {
                translation2[index] = newtranslation;
            }
            dict.dictionary[key] = translation2;
        }
    }
}
