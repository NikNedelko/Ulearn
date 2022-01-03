using System;
using System.Collections.Generic;
using System.Linq;
namespace cheker
{
    class Program
    {
        static bool Check(string str)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char,char>();
            dict['(']=')';
            dict['[']= ']';
            foreach (var symbol in str)
            {
                if (dict.Keys.Contains(symbol))
                stack.Push(symbol);
                else if (dict.Values.Contains(symbol))
                {
                    if (stack.Count == 0) return false;
                        var openBracket = stack.Pop();
                        if (dict[openBracket] != '(') return false;
                }
                else return false;

                //преобразование нижнего в верхнее (нижний работает быстрее, но верхний читабильнее)

                /*
                //char openBracket;
                switch (symbol)
                {
                    case '(':
                    case '[':
                        stack.Push(symbol);
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        openBracket = stack.Pop();
                        if (openBracket != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        openBracket = stack.Pop();
                        if (openBracket != '(') return false;
                        break;
                    default: // не правильные символы
                        return false;
                }
                */
            }
            //if (stack.Count == 0) return true;
            //else return false;
            // write like 
            return stack.Count == 0;
        }
    }
}
