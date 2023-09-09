using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_10_NET
{
    internal class Book : IComparable, ICloneable
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

        public int CompareTo(object obj)
        {
            if(obj is Book)
            {
                return name.CompareTo((obj as Book).name);
            }
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Book(name, autor, page);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Pages
        {
            get { return page; }
            set { page = value; }
        }
    }
    public class SortByName : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Book && y is Book)
            {
                return (x as Book).Name.CompareTo((y as Book).Name);
            }
            throw new NotImplementedException();
        }
    }

    public class SortByAutor : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Book && y is Book)
            {
                return (x as Book).Autor.CompareTo((y as Book).Autor);
            }
            throw new NotImplementedException();
        }
    }
}
