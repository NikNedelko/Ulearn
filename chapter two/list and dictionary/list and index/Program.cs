using System;
using System.Collections;
using System.Collections.Generic;
namespace list_and_index
{

    public class MyList<T> : IEnumerable<T>
    {
        #region 
        T[] array;
        int count = 0;

        public MyList()
        {
            array = new T[100];
        }
        void Enlarge()
        {
            throw new NotImplementedException();
        }
        public void Add(T items)
        {
            if (count == array.Length)
                Enlarge();
            array[count] = items;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return array[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //индексация
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                array[index] = value;
            }
        }
        public int Count { get { return count; } }
        #endregion


    }



    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (var e in list)
                System.Console.WriteLine(e);
            for (int i = 0; i < list.Count; i++)
                System.Console.WriteLine(list[i]);
        }
    }
}
