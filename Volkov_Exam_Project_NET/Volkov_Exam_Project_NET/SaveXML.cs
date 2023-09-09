using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Volkov_Exam_Project_NET
{
    internal class SaveXML
    {
        public void SaveDictionary(MyDictionary dict)
        {
            Console.WriteLine("Enter file name(no spacebar)");
            string filename = Console.ReadLine(); // Пользователь указывает имя файла
            filename.Split(' '); //если вдруг пользователь введет пробел чтобы удалился
            string type1 = string.Empty, type2 = string.Empty;
            if(dict.Type == "RU-ENG") // проверка на тип если RU-ENG то в XML будет писать например RU Машина Eng переводы на английский (просто для красоты в XML)
            {
                type1 = "RU";
                type2 = "ENG";
            }
            else
            {
                type1 = "ENG";
                type2 = "RU";
            }
            XElement wr = new XElement("Dictionary"); // начало документа
            foreach(KeyValuePair<string, List<string>> i in dict.dictionary)
            {
                XElement it = new XElement(type1, new XAttribute("word", i.Key)); // создаем атрибут слова
                foreach(string j in i.Value)
                {
                    XElement translation = new XElement(type2, j); 
                    it.Add(translation); // записываем к слову все его переводы
                }
                wr.Add(it);
            }
            XDocument document = new XDocument(wr);
            document.Save(filename+".xml"); // сохраняем файл
        }
    }
}
