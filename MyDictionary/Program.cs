using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kitaplar = new List<string>();
            kitaplar.Add("Silmarillion");
            kitaplar.Add("Silmarillion");
            Console.WriteLine(kitaplar.Count);

            MyDictionary<string> kitaplar2 = new MyDictionary<string>();
            kitaplar2.Add("Silmarillion");
            kitaplar2.Add("Silmarillion");
            kitaplar2.Add("Silmarillion");
            Console.WriteLine(kitaplar2.Count);
        }
    }
    class MyDictionary <T>
    {
        T[] _array;
        T[] _tempArray;
        public MyDictionary()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }  
        }
    }
}
