using System;

namespace moreLambds
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Func<int, int> f = x => x + 1;
            System.Console.WriteLine(f(1));
            // если не нужно принимать параметры,
            // то можно поставить пустые скобки
            Func<int> generator = () => rnd.Next();
            System.Console.WriteLine(generator());
            Func<double, double, double> h = (a, b) =>
            {
                b = a % b;
                return a % b;
            };

            //лямбда, которая ничего не возвращает
            Action<int> print = x => System.Console.WriteLine(x);

            print(generator());

            Action printRandomNumber = () => System.Console.WriteLine(rnd.Next());
        }
    }
}
