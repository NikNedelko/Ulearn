using System;
using System.Collections.Generic;
using System.Threading;
namespace return_value_and_mistake
{
    class Program
    {

        public static int GetNumber()
        {
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable) return rnd.Next(100);
                Thread.Sleep(100);
            }
            throw new Exception("The netword server was unreachable");
        }
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine(GetNumber());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
