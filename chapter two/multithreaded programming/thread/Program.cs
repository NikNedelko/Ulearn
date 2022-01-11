using System;
using System.Threading;
namespace thread
{
    class Program
    {
        static double MakeWord(int numbers)
        {
            double a = 1;
            for (int i = 0; i < 1000000; i++)
                for (int j = 0; j < 10000; j++)
                    a /= 1.01;
            System.Console.WriteLine(numbers);
            return a;
        }
        static void Main(string[] args)
        {
            var thread = new Thread(new ThreadStart(()=>MakeWord(1)));
            thread.Start();
            thread = new Thread(new ThreadStart(()=> MakeWord(2)));
            thread.Start();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
