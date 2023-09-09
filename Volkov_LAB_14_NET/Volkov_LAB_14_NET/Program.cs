using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace Volkov_LAB_14_NET
{
    internal class Program
    {
        static void Task0()
        {
            // TASK 1
            string str = "danil.volkov.235@gmail.com";
            string reg = @"^\D+\d+@gmail.com";
            Regex regex = new Regex(reg);
            if(regex.IsMatch(str))
            {
                Console.WriteLine(str + " True");
            }
            else
            {
                Console.WriteLine(str + " False");
            }

            // TASK 2
            Console.WriteLine("Phone number");
            string reg2 = @"(\+380|\s380)(\d{2})(\s|-)(\d{3})(\s|-)(\d{2})(\s|-)(\d{2})";
            string str2 = "+38093 235 65 76";
            string str3 = " 38093 235 65 76";
            string str4 = "38093 235 65 76";
            Regex regex2 = new Regex(reg2);
            if(regex2.IsMatch(str2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if(regex2.IsMatch(str3))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if(regex2.IsMatch(str4))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void Task1()
        {
            string pat = @"^(\d{1,3})(.)(\d{1,3})(.)(\d{1,3})(.)(\d{1,3})$";
            string ip = "192.0.1.255";
            string ip2 = "127.0.0.1";
            string ip3 = ".0.0.1";
            Regex reg = new Regex(pat);
            if(reg.IsMatch(ip))
            {
                Console.WriteLine(ip + " - True");
            }
            else
            {
                Console.WriteLine(ip + " - False");
            }
            if(reg.IsMatch(ip2))
            {
                Console.WriteLine(ip2 + " - True");
            }
            else
            {
                Console.WriteLine(ip2 + " - False");
            }
            if(reg.IsMatch(ip3))
            {
                Console.WriteLine(ip3 + " - True");
            }
            else
            {
                Console.WriteLine(ip3 + " - False");
            }
        }

        static void Task2()
        {
            int count = 0;
            string pat = @"[a,e,i,o,u,y,A,E,I,E,U,Y]";
            string text = "Kakoy to text";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            count = matches.Count;
            if(reg.IsMatch(text))
            {
                Console.WriteLine(text + " Count vowels -> " + count);
            }
            else
            {
                Console.WriteLine(text + " Don't have vowels");
            }
        }

        static void Task3()
        {
            string pat = @"^(https://)(\S+)(\.com)$";
            string url = "https://github.com";
            string url2 = "https://github3 .com";
            Regex reg = new Regex(pat);
            if (reg.IsMatch(url))
            {
                Console.WriteLine(url + " - TRUE");
            }
            else
            {
                Console.WriteLine(url + " - FALSE");
            }
            if (reg.IsMatch(url2))
            {
                Console.WriteLine(url2 + " - TRUE");
            }
            else
            {
                Console.WriteLine(url2 + " - FALSE");
            }

        }

        static void Task4()
        {
            string pat = @"^(\S+)$";
            string text = "ajsdijhgiud2312";
            Regex reg = new Regex(pat);
            if (reg.IsMatch(text))
            {
                Console.WriteLine(text + " - TRUE");
            }
            else
            {
                Console.WriteLine(text + " - FALSE");
            }
        }

        static void Task5()
        {
            string pat = @"^([01][0-9]|[1][0-9]|[2][0-3])(:)([0-5][0-9]|)(:)([0-5][0-9])$";
            string time = "23:34:53";
            string time2 = "24:54:53";
            Regex reg = new Regex(pat);
            if (reg.IsMatch(time))
            {
                Console.WriteLine(time + " - TRUE");
            }
            else
            {
                Console.WriteLine(time + " - FALSE");
            }          
            if (reg.IsMatch(time2))
            {
                Console.WriteLine(time2 + " - TRUE");
            }
            else
            {
                Console.WriteLine(time2 + " - FALSE");
            }
        }

        static void Task6()
        {
            string pat = @"^([2])(0)([0-5])([0-9])([1-9])$";
            string index = "20345";
            string index2 = "23555";
            Regex reg = new Regex(pat);
            if (reg.IsMatch(index))
            {
                Console.WriteLine(index + " - TRUE");
            }
            else
            {
                Console.WriteLine(index + " - FALSE");
            }
            if (reg.IsMatch(index2))
            {
                Console.WriteLine(index2 + " - TRUE");
            }
            else
            {
                Console.WriteLine(index2 + " - FALSE");
            }
        }



        static void Main(string[] args)
        {
            //Task0();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }
    }
}
