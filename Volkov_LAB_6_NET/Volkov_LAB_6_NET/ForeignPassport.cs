using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_6_NET
{
    internal class ForeignPassport : Passport
    {
        private int foreign_passport_ID;
        private string visa;

        public ForeignPassport()
        {
            foreign_passport_ID = 0;
            visa = string.Empty;
        }

        public ForeignPassport(string name,string surname, string sex, string citizenship, string date_birthday,int foreign_passport_ID, string visa) : base(name,surname,sex,citizenship,date_birthday)
        {
            this.foreign_passport_ID = foreign_passport_ID;
            this.visa = visa;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter foreign passport ID XX000000");
            foreign_passport_ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your visa");
            visa = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"Foreign passport ID -> {foreign_passport_ID}\nVise -> {visa}\n";
        }
    }
}
