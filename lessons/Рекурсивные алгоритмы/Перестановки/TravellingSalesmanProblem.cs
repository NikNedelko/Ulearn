using System;
namespace Перестановки
{
    public class TravellingSalesmanProblem
    {
        public static void SecondMain()
        {
            System.Console.WriteLine("\n \n \n \n");
            System.Console.WriteLine("Travel is working now");
            System.Console.WriteLine("\n \n");
            MakePermutation(new int[4], 0);
            Console.ReadLine();
        }

        static int[,] prices = new int[,]
         {
            {0, 2, 4, 7},
            {2, 0, 3 ,1},
            {4, 2, 0, 1},
            {3, 5 ,2 ,0}
         };

        static void Evaluate(int[] permutation)
        {
            int price = 0;
            for (int i = 0; i < permutation.Length; i++)      // кольцуем последний переезд
                price += prices[permutation[i], permutation[(i + 1) % permutation.Length]];
            foreach (var item in permutation)
                System.Console.Write(item + " ");
            System.Console.WriteLine(price);
            System.Console.WriteLine();
        }

        static void MakePermutation(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                Evaluate(permutation);
                return;
            }
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                permutation[position] = i;
                MakePermutation(permutation, position + 1);
            }
        }
    }
}