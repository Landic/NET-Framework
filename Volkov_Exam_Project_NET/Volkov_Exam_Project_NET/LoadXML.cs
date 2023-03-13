using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Volkov_Exam_Project_NET
{
    internal class LoadXML
    {
        public void Load(MyDictionary dict)
        {
            Console.WriteLine("Enter file name(no spacebar)");
            string filename = Console.ReadLine();
            filename.Split(' '); //если вдруг пользователь введет пробел чтобы удалился
            XDocument document = XDocument.Load(filename + ".xml");
            foreach (XElement i in document.Root.Elements())
            {
                string key = i.Attribute("word").Value; // находит слово по атрибуту word и записывает в ключ
                List<string> temp = new List<string>(); // создаем лист который будет хранить переводы
                foreach(XElement j in i.Elements()) // перебор переводов
                {
                    temp.Add(j.Value); // добавление переводов в лист 
                }
                dict.dictionary.Add(key, temp); // добавляем в словарь
            }
        }
    }
}
