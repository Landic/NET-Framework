using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Exam_Project_NET
{
    internal interface IAdd
    {
        void MyAdd(MyDictionary dict);
    }

    internal class AddWord : IAdd
    {
        public void MyAdd(MyDictionary dict) 
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            Console.WriteLine("Enter translation");
            string translation1 = Console.ReadLine();
            string[] translation2 = translation1.Split(' '); // записываем в массив строк
            List<string> list = new List<string>(translation2.Select(t => t.Trim())); // добавляем в лист переводы
            dict.dictionary.Add(word, list); // записываем в словарь слово и переводы к нему
        } 
    }

    internal class AddNewTranslation : IAdd
    {
        public void MyAdd(MyDictionary dict) // для добавление дополнительного перевода
        {
            Console.WriteLine("Enter word");
            string key = Console.ReadLine();
            if(!dict.dictionary.ContainsKey(key)) // если такого слова нету то будет исключение
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Word no found!");
            }
            Console.WriteLine("Enter translation");
            string translation = Console.ReadLine();
            string[] translation2 = translation.Split(' '); // записываем в массив строк
            List<string> list = new List<string>(translation2.Select(t => t.Trim())); // добавляем в лист массив строк который соддержит новые переводы
            dict.dictionary[key].AddRange(list); // добавляем в словарь новые переводы к существующему ключу
        }
    }
}
