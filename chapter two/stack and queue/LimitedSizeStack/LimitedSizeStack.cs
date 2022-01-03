using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TodoApplication
{
    public class LimitedSizeStack<T> 
    {
        private int Limit;
        private int Counter;
        LinkedList<T> StackList = new LinkedList<T>();

        public LimitedSizeStack(int limit)
        {
            Limit = limit;
        }

        public void Push(T item)
        {
            StackList.AddLast(item);
            if (StackList.Count > Limit)
                StackList.RemoveFirst();
                Counter++;
        }

        public T Pop()
        {
            if (StackList.Count == 0) throw new InvalidOperationException();
            var result = StackList.Last.Value;
            StackList.RemoveLast();
            Counter--;
            return result;
        }

        public int Count
        {
            get
            {
                return Counter;
            }
        }
    }
}
