using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Net22FinalExam
{
    class GenericAnswer
    {
        static void Mainx(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    }
    class MyCollection<T> where T : class
    {
        private List<T> _collection = new List<T>();
        public void Add(T item)
        {
            _collection.Add(item);
        }
        public T Get(int idx)
        {
            return _collection[idx];
        }
        public IEnumerable<T> GetSortedList()
        {
            IEnumerable<T> results1 = _collection.OrderByDescending(n => n);
            return results1;
        }
    }
}
