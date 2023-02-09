using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_9_NET
{
    internal class Magazine
    {
        private string name_magazine;
        private int year_of_foundation;
        private string description_of_magazine;
        private string phone;
        private string email;
        private int employee;

        public Magazine()
        {
            name_magazine = string.Empty;
            year_of_foundation = 0;
            description_of_magazine = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            employee = 0;
        }

        public Magazine(string name_magazine, int year_of_foundation, string description_of_magazine, string phone, string email,int employee)
        {
            this.name_magazine = name_magazine;
            this.year_of_foundation = year_of_foundation;
            this.description_of_magazine = description_of_magazine;
            this.phone = phone;
            this.email = email;
            this.employee = employee;
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
            Console.WriteLine("Enter count employee");
            employee = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Name magazine -> {name_magazine}\nYear of fundation -> {year_of_foundation}\nDescription of magazine {description_of_magazine}\nPhone -> {phone}\nEmail -> {email}\n" +
                $"Employee -> {employee}";
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

        public static Magazine operator +(Magazine a, int b)
        {
            Magazine result = new Magazine();
            result.employee = a.employee + b;
            return result;
        }

        public static Magazine operator -(Magazine a, int b)
        {
            Magazine result = new Magazine();
            result.employee = a.employee - b;
            return result;
        }

        public static bool operator ==(Magazine a, Magazine b)
        {
            if (a.employee == b.employee)
                return true;
            return false;
        }

        public static bool operator !=(Magazine a, Magazine b)
        {
            return !(a == b);
        }

        public static bool operator <(Magazine a, Magazine b)
        {
            if (a.employee < b.employee)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Magazine a, Magazine b)
        {
            return !(a < b);
        }
    }
}
