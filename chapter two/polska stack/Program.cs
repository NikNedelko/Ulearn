using System;
using System.Collections.Generic;
using System.Linq;
namespace polska_stack
{
    class Program
    {
        static int Compute(string str)
        {
            var stack = new Stack<int>();
            foreach (var symbol in str)
            {
                if (symbol <= '9' && '0' <= symbol)
                {
                    stack.Push(symbol - '0');
                    continue;
                }
                switch (symbol)
                {
                    case '+':
                        {
                            var arg1 = stack.Pop();
                            var arg2 = stack.Pop();
                            stack.Push(arg1 + arg2);
                            break;
                        }
                    case '*':
                        {
                            var arg1 = stack.Pop();
                            var arg2 = stack.Pop();
                            stack.Push(arg1 * arg2);
                            break;
                        }
                }
            }
            return stack.Pop();
        }
    }
}
