using System;
using System.Collections;
namespace IComparer1212
{

    class Point //: IComparable
    {
        public int X;
        public int Y;
        /*
        double DistanceToZero(Point point){
           return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }
        public int CompareTo(object obj)
        {
            var point = (Point)obj;
            var thisDst = DistanceToZero(this); // объект, из которого был вызван данный динамический метод
            var thatDst = DistanceToZero(point);
            return thisDst.CompareTo(thatDst);
        }
        */
    }

    class DIstanceToZeroComparer : IComparer
    {
        double DistanceToZero(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public int Compare(object x, object y)
        {
            return DistanceToZero((Point)x).CompareTo(DistanceToZero((Point)y));
        }
    }
    static class ArrayExtensions
    {
        public static void Swap(this Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i);
            array.SetValue(obj, j);
        }

        public static void BubleSort(this Array array, IComparer comparer)
        {
            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array.GetValue(j);
                    var element0 = array.GetValue(j - 1);
                    if (comparer.Compare(element0, element1) < 0)
                    {
                        array.Swap(j - 1, j);
                    }
                }
            }
        }

        class ProgramStart
        {
            public static void Main(string[] args)
            {
                var intArray = new int[]{2,1,3,4};
                var StringArray = new string[] {"B","A","Z"};
                var doubleArray = new double[] {3,2,1};
                var pointArray = new Point[]{
                    new Point {X=3,Y=3},
                    new Point {X=1,Y=1},
                    new Point {X=2,Y=2}
                };
            }

        }

    }
}
