using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_9_NET
{
    internal class Shop
    {
        private string name_shop;
        private string adres;
        private string description_of_shop;
        private string phone;
        private string email;
        private int square;

        public Shop()
        {
            name_shop = string.Empty;
            adres = string.Empty;
            description_of_shop = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            square = 0;
        }

        public Shop(string name_shop, string adres, string description_of_shop, string phone, string email, int square)
        {
            this.name_shop = name_shop;
            this.adres = adres;
            this.description_of_shop = description_of_shop;
            this.phone = phone;
            this.email = email;
            this.square = square;
        }

        public void Input()
        {
            Console.WriteLine("Enter name shop");
            name_shop = Console.ReadLine();
            Console.WriteLine("Enter adress");
            adres = Console.ReadLine();
            Console.WriteLine("Enter description of the shop");
            description_of_shop = Console.ReadLine();
            Console.WriteLine("Enter phone");
            phone = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            Console.WriteLine("Enter squar shop");
            square = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Name shop -> {name_shop}\nAdress -> {adres}\nDescription of the shop -> {description_of_shop}\nPhone -> {phone}\nEmail -> {email}\nSquare shop -> {square}";
        }

        public string NameShop
        {
            get
            {
                return name_shop;
            }
            set
            {
                name_shop = value;
            }
        }

        public string Adress
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }

        public string DescriptionOfTheShop
        {
            get
            {
                return description_of_shop;
            }
            set
            {
                description_of_shop = value;
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
        
        public int Square
        {
            get
            {
                return square;
            }
            set
            {
                square = value;
            }
        }

        public static Shop operator +(Shop a, int b)
        {
            Shop result = new Shop();
            result.square = a.square + b;
            return result;
        }

        public static Shop operator -(Shop a, int b)
        {
            Shop result = new Shop();
            result.square = a.square - b;
            return result;
        }

        public static bool operator ==(Shop a, Shop b)
        {
            if (a.square == b.square)
                return true;
            return false;
        }

        public static bool operator !=(Shop a, Shop b)
        {
            return !(a == b);
        }

        public static bool operator <(Shop a, Shop b)
        {
            if (a.square < b.square)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Shop a, Shop b)
        {
            return !(a < b);
        }
    }
}
