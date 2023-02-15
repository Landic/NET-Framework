using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_10_NET
{
    internal class List_Book
    {
        Book[] obj;

        public List_Book()
        {
            obj = new Book[0];
        }

        public List_Book(int size) 
        {
            obj = new Book[size];
            for (int i = 0; i < size; i++)
            {
                obj[i] = new Book();
            }
        }

        public List_Book(Book[] arr)
        {
            obj = new Book[arr.Length];
            for (short i = 0; i < arr.Length; i++)
            {
                obj[i] = new Book(arr[i].Name, arr[i].Autor, arr[i].Pages);
            }
        }
        public void Add(Book obj2)
        {
            List_Book obj3 = new List_Book(obj.Length + 1);
            obj3[obj.Length - 1] = obj2;
        }

        public void Delete(Book obj2, int index)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                (obj[i], obj[i + 1]) = (obj[i + 1], obj[i]);
            }
            obj = new Book[obj.Length - 1];
        }

        public bool Find(Book obj2, string find)
        {
            if (obj2.Name == find)
                return true;
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Book i in obj)
                yield return i;
        }

        public Book this[int i]
        {
            get
            {
                if (i < 0 || i >= obj.Length)
                {
                    throw new Exception("Index error");
                }
                else
                    return obj[i];
            }
            set
            {
                if (i < 0 || i >= obj.Length)
                {
                    throw new Exception("Index error");
                }
                else
                    obj[i] = value;
            }
        }

    }
}
