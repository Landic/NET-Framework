using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_6_NET
{
    internal class Web_Site
    {
        private string name_site;
        private string path_to_site;
        private string description_of_the_site;
        private string ip;

        public Web_Site()
        {
            name_site = string.Empty;
            path_to_site = string.Empty;
            description_of_the_site = string.Empty;
            ip = string.Empty;
        }

        public Web_Site(string name_site, string path_to_site, string description_of_the_site, string ip)
        {
            this.name_site = name_site;
            this.path_to_site = path_to_site;
            this.description_of_the_site = description_of_the_site;
            this.ip = ip;
        }

        public void Input()
        {
            Console.WriteLine("Enter name site");
            name_site = Console.ReadLine();
            Console.WriteLine("Enter path to site");
            path_to_site = Console.ReadLine();
            Console.WriteLine("Enter description of the site");
            description_of_the_site = Console.ReadLine();
            Console.WriteLine("Enter IP");
            ip = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name site -> {name_site}\nPath to site -> {path_to_site}\nDescription of the site -> {description_of_the_site}\nIP -> {ip}";
        }

        public string NameSite
        {
            get
            {
                return name_site;
            }
            set
            {
                name_site = value;
            }
        }

        public string PathToSite
        {
            get
            {
                return path_to_site;
            }
            set
            {
                path_to_site = value;
            }
        }

        public string DescriptionOfTheSite
        {
            get
            {
                return description_of_the_site;
            }
            set
            {
                description_of_the_site = value;
            }
        }
        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
    }
}
