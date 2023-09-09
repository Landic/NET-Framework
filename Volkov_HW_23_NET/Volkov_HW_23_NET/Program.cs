using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Volkov_HW_23_NET
{
    internal class Program
    {
        static void Task1()
        {
            string pat = @"a.b";
            string text = "ahd acb aeb aeeb adcb axeb";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task2()
        {
            string pat = @"a..a";
            string text = "aba aca aea abba adca abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task3()
        {
            string pat = @"([a.ea])([a.ba])";
            string text = "aa aba abba abbba abea abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task4()
        {
            string pat = @"(ab+a)";
            string text = "aa aba abba abbba abca abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task5()
        {
            string pat = @"(ab*a)";
            string text = "aa aba abba abbba abca abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task6()
        {
            string pat = @"(a+a|ab?a)";
            string text = "aa aba abba abbba abca abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task7()
        {
            string pat = @"(a+a|ab*a)";
            string text = "aa aba abba abbba abca abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }

        static void Task8()
        {
            string pat = @"(a?b)";
            string text = "ab abab abab abababab abea";
            Regex reg = new Regex(pat);
            MatchCollection matches = reg.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            int count = matches.Count;
            Console.WriteLine("ab count -> " + count);
        }


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task8();
        }
    }
}
