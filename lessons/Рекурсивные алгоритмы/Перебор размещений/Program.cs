using System;

namespace Перебор_размещений
{
    class Program
    {
        static void Main(string[] args)
        {
         MakeCombination(new bool[5],3,0);
        }

        static void MakeCombination(bool[] combination, int elementsLeft, int position)
        {
            if (elementsLeft == 0)
            {
                for (int i = position; i < combination.Length; i++) combination[i] = false;
                foreach (var item in combination)
                    System.Console.Write((item ? 1 : 0) + " ");
                    System.Console.WriteLine();
                    return;
            }
            if (position == combination.Length)
            return;
            combination[position] = false;
            MakeCombination(combination, elementsLeft, position + 1);
            combination[position] = true;
            MakeCombination(combination, elementsLeft - 1, position + 1);
        }
    }
}
