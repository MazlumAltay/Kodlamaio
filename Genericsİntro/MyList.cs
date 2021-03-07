using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T> // Burada verdiğimiz T(Type) Alt kısımda belirteceğimiz ne varsa türünü otamatik atayacak.!
    {
        T[] items;
        //Consturactor(ctor-> tab tab yap.!)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //Add'e ekleyebilmek için new'lemek gerek.!
        {
            T[] tempArray = items; // Newleyip önceki elemanların uçmasını engellemek için elemanı başka array ile tutturuyoruz.!
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
