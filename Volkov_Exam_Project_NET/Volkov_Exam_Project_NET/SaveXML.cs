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
            string filename = Console.ReadLine();
            filename.Split(' '); //если вдруг пользователь введет пробел чтобы удалился
            string type1 = string.Empty, type2 = string.Empty;
            if(dict.Type == "RU-ENG")
            {
                type1 = "RU";
                type2 = "ENG";
            }
            else
            {
                type1 = "ENG";
                type2 = "RU";
            }
            XElement wr = new XElement("Dictionary");
            foreach(KeyValuePair<string, List<string>> i in dict.dictionary)
            {
                XElement it = new XElement(type1, new XAttribute("word", i.Key));
                foreach(string j in i.Value)
                {
                    XElement translation = new XElement(type2, j);
                    it.Add(translation);
                }
                wr.Add(it);
            }
            XDocument document = new XDocument(wr);
            document.Save(filename+".xml");
        }
    }
}
