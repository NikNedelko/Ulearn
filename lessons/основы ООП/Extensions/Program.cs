using System;

namespace Extensions
{
    static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }
    class Program
    {
        static double GenerateDouble(Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
        public static void Main(string[] args)
        {
            var rnd = new Random();
            System.Console.WriteLine(rnd.NextDouble());
            System.Console.WriteLine(GenerateDouble(rnd, 10, 20));
            System.Console.WriteLine(rnd.NextDouble(10, 20));
        }


    }
}
