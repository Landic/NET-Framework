using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Volkov_Exam_Project_NET
{
    internal interface IRemove
    {
        void MyRemove(MyDictionary dict);
    }

    internal class RemoveWord : IRemove
    {
        public void MyRemove(MyDictionary dict)
        {
            Console.WriteLine("Enter word to remove");
            string word = Console.ReadLine();
            if (dict.dictionary.ContainsKey(word))
            {
                dict.dictionary.Remove(word);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(" ----------------\n" +
                                  "| Word not found |\n" +
                                  " ----------------");
                Thread.Sleep(500);
                Console.ResetColor();
            }
        }
    }

    internal class RemoveTranslation : IRemove
    {
        public void MyRemove(MyDictionary dict)
        {
            Console.WriteLine("Enter word to found");
            string key = Console.ReadLine();
            Console.WriteLine("Enter translation to remove");
            string word = Console.ReadLine();
            if (dict.dictionary.TryGetValue(key, out List<string> translation) && translation.Count == 1)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(" ---------------------------------\n" +
                                  "| Can't delete single translation |\n" +
                                  " ---------------------------------");
                Thread.Sleep(500);
                Console.ResetColor();
            }
            else
            {
                dict.dictionary[key].Remove(word);
            }
        }
    }
}
