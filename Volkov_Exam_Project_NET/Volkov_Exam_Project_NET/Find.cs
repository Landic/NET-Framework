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
            foreach (KeyValuePair<string, List<string>> i in dict.dictionary) // foreach для перебора
            {
                if (i.Key == word) // ищет по ключу если такой ключ есть то выводит перевод
                {
                    Console.WriteLine($"{i.Key} - {string.Join(" ", i.Value)}");
                    return; 
                }
            }
            Console.ForegroundColor = ConsoleColor.Red; 
            throw new Exception("Not found");// исключение если слово не найдено
        }   
    }
}
