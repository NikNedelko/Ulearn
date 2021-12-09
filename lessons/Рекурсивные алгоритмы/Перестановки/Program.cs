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

                                                       // место обработки в настоящий момент
        static void MakePermutation(int[] permutation, int position)
        {
            if (position == permutation.Length)//выводим окончательное решение
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
                bool found = false;//флаг
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue; // если флаг не поднят, то элемент i в перестановке был не найден
                permutation[position] = i;//ставим элемент
                MakePermutation(permutation, position + 1);

            }
        }
    }
}
