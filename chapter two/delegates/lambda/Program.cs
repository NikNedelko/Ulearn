using System;
using System.Collections;
using System.Collections.Generic;
namespace FuncAction
{
    // public delegate int ObjectComparer<T>(T x, T y);

    class Program
    {
        public static void Sort<T>(T[] array, Func<T, T, int> comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (comparer(element1, element2) > 0)
                    {
                        var temporary = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporary;
                    }
                }
            }
        }



        public static int CompareLength(string x, string y)
        {
            return x.CompareTo(y.Length);
        }
        public class AlphabeticComparer
        {
            public bool Descending { get; set; }
            public int Compare(string x, string y)
            {
                return x.CompareTo(y) * (Descending ? -1 : 1);
            }
        }




        static void Main()
        {
            var strings = new[] { "A", "B", "AA" };
            //         take this      give this
            Sort(strings, (x, y) => x.Length.CompareTo(y.Length));
        }

    }

}

