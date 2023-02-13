using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_10_NET
{
    internal class Book
    {
        private string name;
        private string autor;
        private int page;
        public Book()
        {
            name = string.Empty;
            autor= string.Empty;
            page = 0;
        }
        public Book(string name, string autor, int page)
        {
            this.name = name;
            this.autor = autor;
            this.page = page;
        }

        public void Input()
        {
            Console.WriteLine("Enter name book");
            name = Console.ReadLine();
            Console.WriteLine("Enter autor");
            autor = Console.ReadLine();
            Console.WriteLine("Enter page");
            page = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Name book -> {name}\nAutor -> {autor}\nPage -> {page}\n";
        }

        public string Name
        {
            get;set;
        }
    }
}
