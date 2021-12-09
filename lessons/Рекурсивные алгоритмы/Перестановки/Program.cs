using System;
namespace Перестановки
{
    class Program
    {
        static void Main(string[] args)
        {
            MakePermutation(new int[5], 0);
            TravellingSalesmanProblem.SecondMain();
            Console.ReadLine();
        }
        
        static void MakePermutation(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                foreach (var item in permutation)
                {
                    System.Console.Write(item + " ");
                }
                System.Console.WriteLine();
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
