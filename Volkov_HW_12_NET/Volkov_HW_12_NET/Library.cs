using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_12_NET
{
    internal class Library
    {
        Book[] arr;

        public Library(int size)
        {
            arr = new Book[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Book();
            }
        }

        public Library(Book[] book) 
        {
            arr = new Book[book.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Book(book[i].Name, book[i].Autor, book[i].Pages);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
    }
}
