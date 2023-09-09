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
            if (dict.dictionary.ContainsKey(word)) // ищем слово и удаляем его вместе с переводом
            {
                dict.dictionary.Remove(word);
            }
            else // если слово не найдено исключение
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Word not found");
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
            if (dict.dictionary.TryGetValue(key, out List<string> translation) && translation.Count == 1) // проверяет наличие ключа и если перевод только один то вылазит исключение
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("You can't delete a single translation");
            }
            else // если все нормально удаляет перевод один
            {
                dict.dictionary[key].Remove(word); 
            }
        }
    }
}
