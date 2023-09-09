using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_15_NET
{
    internal class CreditCard
    {
        private string NS;
        private string date;
        private int PIN;
        private int CreditLimit;
        private int balance;
        List<MyDelegate> list = new List<MyDelegate>();
        private string history;

        public event MyDelegate ev
        {
            // Используем аксессоры событий
            add
            {
                list.Add(value);
            }

            remove
            {
                list.Remove(value);
            }
        }

        public CreditCard()
        {
            NS = string.Empty;
            date = string.Empty;
            PIN = 0;
            CreditLimit = 0;
            balance = 0;
            history = string.Empty;
        }
        
        public CreditCard(string NS, string date, int PIN, int CreditLimit, int balance)
        {
            this.NS = NS;
            this.date = date;
            this.PIN = PIN;
            this.CreditLimit = CreditLimit;
            this.balance = balance;
        }

        public void Init()
        {
            Console.WriteLine("Enter name surname");
            NS = Console.ReadLine();
            Console.WriteLine("Enter date end card MM/YY");
            date = Console.ReadLine();
            Console.WriteLine("Enter PIN code");
            PIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter credit limit");
            CreditLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter balance");
            balance = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"NS -> {NS}\nDate end -> {date}\nPIN-code -> {PIN}\nCredit limit -> {CreditLimit}$\nBalance -> {balance}$";
        }

        public void Event()
        {
            if(list.Count != 0)
            {
                foreach (MyDelegate i in list)
                    i();
            }
        }

        public void AddBalance()
        {
            int add;
            Console.WriteLine("Enter summ to add balance");
            add = Convert.ToInt32(Console.ReadLine());
            balance += add;
            history += "Add to balance -> " + add;
        }

        public void History()
        {
            Console.WriteLine(history + "\n -10$ - spent on food\n -100$ - spent on medicin");
        }

        public void Credit()
        {
            Console.WriteLine("Credit start!");
        }

        public void ReachingTheSum()
        {
            int reaching;
            Console.WriteLine("Enter reaching the sum");
            reaching = int.Parse(Console.ReadLine());
            if(balance > reaching)
            {
                Console.WriteLine("Summ reaching");
            }
            else
            {
                Console.WriteLine("Sum not reaching");
            }
        }

        public void ChangePIN()
        {
            int newpin = 0;
            Console.WriteLine("Enter old PIN-code");
            newpin = Convert.ToInt32(Console.ReadLine());
            if(newpin != PIN)
            {
                throw new Exception("You enter wrong PIN");
            }
            else
            {
                Console.WriteLine("Enter new PIN-code");
                PIN = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
