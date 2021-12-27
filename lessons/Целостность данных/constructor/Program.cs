using System;

namespace constructor
{
    public class TournirInfo
    {
        /*
        public int TeamsCount { get; set; }
        public string[] TeamsNames { get; set; }
        public double[,] Scores { get; set; }
        */
        // Модифицируем поля в ReadOnly и теперь они могут быть изменены только в конструкторе класса
        public readonly int TeamsCount;
        public readonly string[] TeamsNames;
        public readonly double[,] Scores ;

        // вызывает конструктор, который был бы вызван при отправке числа 4
        public TournirInfo() : this(4)
        {

        }
        public TournirInfo(int teamsCount)
        {
            TeamsCount = teamsCount;
            TeamsNames = new string[teamsCount];
            Scores = new double[teamsCount, teamsCount];
        }

        public TournirInfo(params string[] Names)
        {
            TeamsCount = Names.Length;
            TeamsNames = Names;
            Scores = new double[TeamsCount, TeamsCount];
        }
    }

    public class Program
    {
        public static void Main()
        {
            Pract.Check();

        }

    }

    public class Pract
    {
        public static void Check()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());
            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());

            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());

            Console.WriteLine(new Vector(0, 0).ToString());
        }
    }
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length => Math.Sqrt(X * X + Y * Y);

        // добавьте конструктор!
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
        }
    }



}
