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
                string key = i.Attribute("word").Value;
                List<string> temp = new List<string>();
                foreach(XElement j in i.Elements())
                {
                    temp.Add(j.Value);
                }
                dict.dictionary.Add(key, temp);
            }
        }
    }
}
