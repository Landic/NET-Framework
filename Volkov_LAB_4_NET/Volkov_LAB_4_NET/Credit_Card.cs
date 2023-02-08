using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_4_NET
{
    internal class Credit_Card
    {
        private string name;
        private string card_number;
        private string cvc;
        private string date_end;

        public Credit_Card()
        {
            name= string.Empty;
            card_number = string.Empty;
            cvc = string.Empty;
            date_end = string.Empty;
        }

        public Credit_Card(string name, string card_number, string cvc, string date_end)
        {
            this.name = name;
            this.card_number = card_number;
            this.cvc = cvc;
            this.date_end = date_end;
        }

        public void Init()
        {
            string Symbols = "1234567890-=!@#$%^&*()<>?';:{}[]\\|`~";
            string symbols2 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM,./;'[]\\|:\"<>?()-=+_!@#$%^&*`~";
            char[] symbols1 = Symbols.ToCharArray();
            char[] symbols3 = symbols2.ToCharArray();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            char[] name1 = name.ToCharArray();
            for (int i = 0; i < name1.Length; i++)
            {
                for (int j = 0; j < symbols1.Length; j++)
                {
                    if (name1[i] == symbols1[j])
                    {
                        throw new Exception($"Username contains invalid characters!");
                    }
                }
            }
            Console.WriteLine("Enter card number");
            card_number = Console.ReadLine();
            char[] card_number1 =  card_number.ToCharArray();
            for (int i = 0; i < card_number1.Length; i++)
            {
                for (int j = 0; j < symbols3.Length; j++)
                {
                    if (card_number1[i] == symbols3[j])
                    {
                        throw new Exception($"Card number contains invalid characters!");
                    }
                }
            }
            if (card_number.Length != 16)
            {
                throw new Exception($"Card number less or more than 16 digits");
            }
            Console.WriteLine("Enter CVC");
            cvc = Console.ReadLine();
            char[] cvc1 = cvc.ToCharArray();
            for (int i = 0; i < cvc1.Length; i++)
            {
                for (int j = 0; j < symbols3.Length; j++)
                {
                    if (cvc[i] == symbols3[j])
                    {
                        throw new Exception($"CVC contains invalid characters!");
                    }
                }
            }
            if (cvc.Length != 3)
            {
                throw new Exception($"CVC less or more than 3 digits");
            }
            Console.WriteLine("Enter date");
            date_end = Console.ReadLine();
            if(date_end.Length != 5)
            {
                throw new Exception($"Date error!");
            }
            char[] date_end1 = date_end.ToCharArray();
            for (int i = 0; i < date_end1.Length; i++)
            {
                for (int j = 0; j < symbols3.Length; j++)
                {
                    if (date_end1[i] == symbols3[j])
                    {
                        throw new Exception($"Date contains invalid characters!");
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Card number -> {card_number}\nCVC -> {cvc}\nName -> {name}\nDate -> {date_end}";
        }
    }
}
