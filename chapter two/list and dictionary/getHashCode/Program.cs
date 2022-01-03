using System;
using System.Collections.Generic;

namespace getHashCode
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return X == point.X && Y == point.Y;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode()* 1039 + Y.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point { X = 1, Y = 1 };
            Point point2 = new Point { X = 1, Y = 1 };

            var dict = new Dictionary<Point, string>();
            dict[point1] = "Test";
        }
    }
}
