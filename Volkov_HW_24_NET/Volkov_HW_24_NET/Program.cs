using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Volkov_HW_24_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop[] shop = new Shop[3] { new Shop("Milk", 39.50, "06.03.2023"), new Shop("Red caviar", 250, "06.03.2023"), new Shop("Black caviar", 5000, "06.03.2023") };
            XmlTextWriter wr = new XmlTextWriter("../../Shop.xml", Encoding.UTF8);
            wr.WriteStartDocument();
            wr.Formatting = Formatting.Indented;
            wr.IndentChar = '\t';
            wr.Indentation = 1;
            wr.WriteStartElement("Product_Purchase");
            foreach(Shop j in shop)
            {
                wr.WriteStartElement("name");
                wr.WriteString(j.Product);
                wr.WriteEndElement();
                wr.WriteStartElement("price");
                wr.WriteString(j.Price.ToString());
                wr.WriteEndElement();
                wr.WriteStartElement("data");
                wr.WriteString(j.Date);
                wr.WriteEndElement();
            }
            Console.WriteLine("Save in XML");
            wr.WriteEndElement();
            wr.Close();
        }
    }
}
