using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_5_NET
{
    internal class City
    {
        private string name_city;
        private string country;
        private int people;
        private string phone;
        private string[] areas;
        private string areas2;

        public City()
        {
            name_city = string.Empty;
            country = string.Empty;
            people = 0;
            phone = string.Empty;
            areas = null;
            areas2 = string.Empty;
        }

        public City(string value_name_city, string value_country, int value_people, string value_phone, string value_areas2)
        {
            name_city = value_name_city;
            country = value_country;
            people = value_people;
            phone = value_phone;
            areas2 = value_areas2;
            areas = areas2.Split(' ');
        }

        public void Input()
        {
            Console.WriteLine("Enter name city");
            name_city = Console.ReadLine();
            Console.WriteLine("Enter country");
            country = Console.ReadLine();
            Console.WriteLine("Enter count people");
            people = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter code phone");
            phone = Console.ReadLine();
            Console.WriteLine("Enter areas in the city");
            areas2 = Console.ReadLine();
            areas = areas2.Split(' ');
        }

        public void Output()
        {
            Console.WriteLine($"City name -> {name_city}\nCountry -> {country}\nPeople -> {people}\nPhone{phone}\nAreas -> ");
            foreach (string n in areas)
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        public string Name_City
        {
            get
            {
                return name_city;
            }
            set
            {
                name_city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public int People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
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

        public string this[int index]
        {
            get
            {
                return areas[index];
            }
            set
            {
                areas[index] = value;
            }
        }

        public static City operator +(City a, int b)
        {
            City result = new City();
            result.people = a.people + b;
            return result;
        }

        public static City operator -(City a, int b)
        {
            City result = new City();
            result.people = a.people - b;
            return result;
        }

        public static bool operator ==(City a, City b)
        {
            if (a.people == b.people)
                return true;
            return false;
        }

        public static bool operator !=(City a, City b)
        {
            return !(a == b);
        }

        public static bool operator <(City a, City b)
        {
            if (a.people < b.people)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(City a, City b)
        {
            return !(a < b);
        }
    }
}
