using System;
using System.Collections.Generic;
using System.Linq;
namespace sort_with_genetic
{
    static class Sorter
    // или 
    //public static void Sort<T>(T[] array)
    //where T : IComparable
    {
        public static void BubbleSort<T>(this T[] array)
        where T : IComparable
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    T element1 = array[j - 1];
                    T element2 = array[j];
                    //del aft 7 line
                    //IComparable comparableElement1 = (IComparable)element1;
                    //del cast
                    if (element1.CompareTo(element2) < 0)
                    {
                        T temporary = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporary;
                    }
                }
        }
    }
    class Program
    {
        public static void Sort(Array array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1);
                    object element2 = array.GetValue(j);
                    IComparable comparableElement1 = (IComparable)element1;
                    if (comparableElement1.CompareTo(element2) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }
                }
        }
        static void Main(string[] args)
        {
             var array = new int[] { 1, 2, 3, 4, 5, };

            // Sorter<int>.Sort(new int[] { 1, 2, 3, 4, 5, });
            //Sorter<Point>.Sort(new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } });
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 2, 1, 3 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));
        }

        // https://ulearn.me/course/basicprogramming2/Maksimum_v_massive_e3f3c78d-8d68-40cb-8b1e-a1912396dbef
        static T Max<T>(params T[] source) 
        where T : IComparable
        {
            if (source.Length == 0)
                return default(T);
            T result = source[0];
            for (int i = 0; i < source.Length; i++)
            {
                var element = source[i];
                if (result.CompareTo(element) < 0) result = element;
            }
            return result;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
