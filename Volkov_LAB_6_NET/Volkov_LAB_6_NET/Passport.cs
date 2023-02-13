using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class Passport
    {
        protected string name;
        protected string surname;
        protected string sex;
        protected string citizenship;
        protected string date_birthday;

        public Passport()
        {
            name = string.Empty;
            surname = string.Empty;
            sex = string.Empty;
            citizenship = string.Empty;
            date_birthday = string.Empty;
        }

        public Passport(string name, string surname, string sex, string citizenship, string date_birthday)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.citizenship = citizenship;
            this.date_birthday = date_birthday;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            surname = Console.ReadLine();
            Console.WriteLine("Enter sex");
            sex = Console.ReadLine();
            Console.WriteLine("Enter citizenship");
            citizenship = Console.ReadLine();
            Console.WriteLine("Enter date birthday DD.MM.YYYY");
            date_birthday = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name -> {name}\nSurname -> {surname}\nSex -> {sex}\nCitizenship -> {citizenship}\nDate birthday -> {date_birthday}\n";
        }
    }
}
