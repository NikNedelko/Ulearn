using System;
using System.Collections;
using System.Collections.Generic;
namespace problem
{
    class Program
    {
        public static void Sort(string[] array, IComparer<string> comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array[j - 1];
                    var element2 = array[j];
                    if (comparer.Compare(element1, element2) > 0)
                    {
                        var temporary = array[j];
                        array[j]=array[j - 1];
                        array[j-1]=temporary;
                    }
                }
            }
        }

        class StringLengthComparer : IComparer<string>
        {
            
            public int Compare(string x, string y)
            {
                return x.CompareTo(y.Length);
            }

            class StringComparer : IComparer<string>
            {
                public bool Descending { get; set; }
                public int Compare(string x, string y){
                    return x.CompareTo(y)* 
                    (Descending ? -1 : 1);
                }
            }
             static void Main()
            {
                var strings = new[] { "A", "B", "AA" };
                Sort(strings, new StringComparer {Descending = true}); //false - порядок убывания, true - порядок возрастания
                Sort(strings, new StringLengthComparer());
            }

        }
    }

}
