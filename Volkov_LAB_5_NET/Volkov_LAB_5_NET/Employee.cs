using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_LAB_5_NET
{
    internal class Employee
    {
        private string[] NSP; // name surname patronymic
        private string birthday;
        private string phone;
        private string email;
        private string job_title;
        private string job_responsibilities;
        private int payday;

        public Employee()
        {
            NSP = null;
            birthday = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            job_title = string.Empty;
            job_responsibilities = string.Empty;
            payday = 0;
        }

        public Employee(string[] NSP, string birthday, string phone, string email, string job_title, string job_responsibilities, int payday)
        {
            this.NSP = NSP;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.job_title = job_title;
            this.job_responsibilities = job_responsibilities;
            this.payday = payday;
        }

        public void Input()
        {
            Console.WriteLine("Enter NSP");
            string nsp2 = Console.ReadLine();
            NSP = nsp2.Split(' ');
            Console.WriteLine("Enter birthday");
            birthday = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            phone = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            Console.WriteLine("Enter job title");
            job_title = Console.ReadLine();
            Console.WriteLine("Enter job resposibilities");
            job_responsibilities = Console.ReadLine();
            Console.WriteLine("Enter payday");
            payday = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.Write("NSP -> ");
            foreach (string n in NSP)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Birthday -> {birthday}\nPhone number -> {phone}\n" +
                $"Email -> {email}\nJob title -> {job_title}\nJob responsibilities -> {job_responsibilities}\nPayday -> {payday}");
        }

        public string this[int index]
        {
            get
            {
                return NSP[index];
            }
            set
            {
                NSP[index] = value;
            }
        }
        
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
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

        public string JobTitle
        {
            get
            {
                return job_title;
            }
            set
            {
                job_title = value;
            }
        }

        public string JobResponsibilities
        {
            get 
            { 
                return job_responsibilities; 
            }
            set
            {
                job_responsibilities = value;
            }
        }

        public static Employee operator +(Employee a, Employee b)
        {
            Employee result = new Employee();
            result.payday = a.payday + b.payday;
            return result;
        }

        public static Employee operator +(Employee a, int b)
        {
            Employee result = new Employee();
            result.payday = a.payday + b;
            return result;
        }

        public static Employee operator -(Employee a, Employee b)
        {
            Employee result = new Employee();
            result.payday = a.payday - b.payday;
            return result;
        }

        public static Employee operator -(Employee a, int b)
        {
            Employee result = new Employee();
            result.payday = a.payday - b;
            return result;
        }

        public static bool operator ==(Employee a, Employee b)
        {
            if(a.payday == b.payday) 
                return true;
            return false;
        }

        public static bool operator != (Employee a, Employee b)
        {
            return !(a == b);
        }

        public static bool operator <(Employee a, Employee b)
        {
            if(a.payday < b.payday)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Employee a, Employee b)
        {
            return !(a < b);
        }
    }
}
