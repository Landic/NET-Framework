using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_8_NET
{
    internal class International_Passport
    {
        private string NS;
        private string date_take;
        private string date_end;
        private string country;
        private string ID;

        public International_Passport()
        {
            NS = string.Empty;
            date_take = string.Empty;
            date_end = string.Empty;
            country = string.Empty;
            ID = string.Empty; // 9
        }

        public International_Passport(string NS, string date_take, string date_end, string country, string ID)
        {
            this.NS = NS;
            this.date_take = date_take;
            this.date_end = date_end;
            this.country = country;
            this.ID = ID;
        }

        public void Input()
        {
            string Symbols1 = "1234567890-=+_!@#$%^&*()\\|';\":?><,./`~";
            string Symbols2 = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm,./<>?;':\"[]{}\\|-=_+`~";
            Console.WriteLine("Enter Name and Surname");
            NS = Console.ReadLine();
            string[] ns1 = NS.Split(' ');
            if(ns1.Length != 2) 
            {
                throw new Exception($"You didn't enter your last name!");
            }
            for (int i = 0; i < NS.Length; i++)
            {
                for (int j = 0; j < Symbols1.Length; j++)
                {
                    if (NS[i] == Symbols1[j])
                    {
                        throw new Exception($"You entered invalid characters!");
                    }
                }
            }
            Console.WriteLine("Enter date take DD|MM|YYYY");
            date_take = Console.ReadLine();
            string[] date_take1 = date_take.Split(' ');
            for (int i = 0; i < date_take.Length; i++)
            {
                for (int j = 0; j < Symbols2.Length; j++)
                {
                    if (date_take[i] == Symbols2[j])
                    {
                        throw new Exception($"You entered invalid characters!");
                    }
                }
            }
            if(date_take1.Length != 3)
            {
                throw new Exception($"You did not enter the month or day or year!");
            }
            Console.WriteLine("Enter date end DD|MM|YYYY");
            date_end = Console.ReadLine();
            string[] date_end1 = date_end.Split(' ');
            for (int i = 0; i < date_end.Length; i++)
            {
                for (int j = 0; j < Symbols2.Length; j++)
                {
                    if (date_end[i] == Symbols2[j])
                    {
                        throw new Exception($"You entered invalid characters!");
                    }
                }
            }
            if (date_end1.Length != 3)
            {
                throw new Exception($"You did not enter the month or day or year!");
            }
            Console.WriteLine("Enter country");
            country = Console.ReadLine();
            for (int i = 0; i < country.Length; i++)
            {
                for (int j = 0; j < Symbols1.Length; j++)
                {
                    if (country[i] == Symbols1[j])
                    {
                        throw new Exception($"You entered invalid characters!");
                    }
                }
            }
            Console.WriteLine("Enter ID");
            ID = Console.ReadLine();
            for (int i = 0; i < ID.Length; i++)
            {
                for (int j = 0; j < Symbols2.Length; j++)
                {
                    if (ID[i] == Symbols2[j])
                    {
                        throw new Exception($"You entered invalid characters!");
                    }
                }
            }
            if(ID.Length != 9)
            {
                throw new Exception($"You entered less than or more than 9 numbers!");
            }
        }

        public override string ToString()
        {
            return $"Name, Surname -> {NS}\nDate take -> {date_take}\nDate end -> {date_end}\nCountry -> {country}\nID -> {ID}";
        }
    }
}
