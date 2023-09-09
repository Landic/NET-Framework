using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_10_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] obj = new Book[3];
            obj[0] = new Book("g", "j", 2);
            obj[1] = new Book("a", "t", 3);
            obj[2] = new Book("w", "a", 5);
            foreach(Book book in obj)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------------------------");
            Array.Sort(obj, new SortByName());
            foreach (Book book in obj)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------------------------");
            Array.Sort(obj, new SortByAutor());
            foreach (Book book in obj)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------------------------");
            Array.Sort(obj);
            foreach(Book book in obj)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("------------------------------------");
            Book obj2 = obj[0];
            Console.WriteLine(obj2);
            List_Book obj5 = new List_Book(obj);
            Console.WriteLine("------------------------------------");
            foreach (List_Book i in obj5)
                Console.WriteLine(i);

        }
    }
}
