using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Volkov_Exam_Project_NET
{
    internal class FindTranslation
    {
        public void MyFind(MyDictionary dict) 
        {
            Console.WriteLine("Enter word for translation");
            string word = Console.ReadLine();
            foreach (KeyValuePair<string, List<string>> i in dict.dictionary)
            {
                if (i.Key == word)
                {
                    Console.WriteLine($"{i.Key} - {string.Join(" ", i.Value)}");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine(" ----------------\n" +
                                      "| No translation |\n" +
                                      " ----------------");
                    Console.ResetColor();
                    Thread.Sleep(500);
                }
            }
        }   
    }
}
