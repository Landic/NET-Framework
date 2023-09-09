using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_12_NET
{
    internal class Book : IComparable, ICloneable
    {
        private string name;
        private string autor;
        private int pages;

        public Book()
        {
            name = string.Empty;
            autor= string.Empty;
            pages = 0;
        }

        public Book(string name, string autor, int pages)
        {
            this.name = name;
            this.autor = autor;
            this.pages = pages;
        }

        public override string ToString()
        {
            return $"Name book -> {name}\nAutor -> {autor}\nPages -> {pages}\n";
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
            get { return pages; }
            set { pages = value; }
        }

        public object Clone()
        {
            return new Book(name, autor, pages);
        }

        public int CompareTo(object obj)
        {
            if (obj is Book)
            {
                return name.CompareTo((obj as Book).name);
            }
            throw new NotImplementedException();
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
