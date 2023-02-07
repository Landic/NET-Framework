using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Magazine
    {
        private string name_magazine;
        private int year_of_foundation;
        private string description_of_magazine;
        private string phone;
        private string email;

        public Magazine()
        {
            name_magazine = string.Empty;
            year_of_foundation = 0;
            description_of_magazine = string.Empty;
            phone = string.Empty;
            email = string.Empty;
        }

        public Magazine(string name_magazine, int year_of_foundation, string description_of_magazine, string phone, string email)
        {
            this.name_magazine = name_magazine;
            this.year_of_foundation = year_of_foundation;
            this.description_of_magazine = description_of_magazine;
            this.phone = phone;
            this.email = email;
        }

        public void Input()
        {
            Console.WriteLine("Enter name magazine");
            name_magazine = Console.ReadLine();
            Console.WriteLine("Enter year of fundation");
            year_of_foundation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter description of magazine");
            description_of_magazine = Console.ReadLine();
            Console.WriteLine("Enter phone");
            phone = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name magazine -> {name_magazine}\nYear of fundation -> {year_of_foundation}\nDescription of magazine {description_of_magazine}\nPhone -> {phone}\nEmail -> {email}\n";
        }

        public string NameMagazine
        {
            get
            {
                return name_magazine;
            }
            set
            {
                name_magazine = value;
            }
        }

        public int YearOfFoundation
        {
            get
            {
                return year_of_foundation;
            }
            set
            {
                year_of_foundation = value;
            }
        }

        public string DescriptionOfMagazine
        {
            get
            {
                return description_of_magazine;
            }
            set
            {
                description_of_magazine = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
