using System;

namespace Склейка_массивов
{
    class Program
    {
        public static void Main()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        static Array Combine(params Array[] arrays)
        {
            Type checkType;
            int summaryLength = 0;
            try
            {
                 checkType = arrays[0].GetType().GetElementType();
            }
            catch (System.Exception)
            {
                return null;
            }
            foreach (var array in arrays)
            {
                if (array.GetType().GetElementType() != checkType) return null;
                summaryLength += array.Length;
            }
            var result = Array.CreateInstance(arrays[0].GetType().GetElementType(), summaryLength);
            int index = 0;
            for (var i = 0; i < arrays.Length; i++)
            {
                Array.Copy(arrays[i], 0, result, index, arrays[i].Length);
                index += arrays[i].Length;
            }
            return result;
        }
    }
}
