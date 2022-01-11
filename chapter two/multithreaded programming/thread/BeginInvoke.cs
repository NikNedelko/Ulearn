using System;
using System.Threading;
namespace beginIn
{
    class Program
    {
        static double MakeWork(int numbers)
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
            var func = new Func<int,double>(MakeWork);
            var result = func.BeginInvoke(1,null,null);
            for(int i = 0;i<100;i++)
            System.Console.WriteLine(".");
            var returnedValue = func.EndInvoke(result);
        }
    }
}
