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
            if (dict.dictionary.ContainsKey(wordreplace)) // ищем слово если находит срабатывает тело проверки
            {
                List<string> value = dict.dictionary[wordreplace]; // сохраняем переводы в отдельный лист
                dict.dictionary.Remove(wordreplace); // удаляем старое слово
                dict.dictionary.Add(wordnew, value); // добавляем новое и к нему переводы которые мы сохранили

            }
            else // если слово не найдено вылазит исключение
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("There is no such word");
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
            List<string> translation2 = dict.dictionary[key]; // получаем список переводов
            int index = translation2.IndexOf(translation); // находим индекс перевода
            if (index >= 0) // если больше или равно нулю то срабатывает код в теле проверки
            {
                translation2[index] = newtranslation; // замена текущего перевода на новый
                dict.dictionary[key] = translation2; // обновляем список переводов
            }
            else // если меньше нуля то есть не найден перевод то исключение
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                throw new Exception("Translation not found!");
            }
        }
    }
}
