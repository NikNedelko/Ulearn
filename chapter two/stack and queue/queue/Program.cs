using System;
using System.Collections.Generic;
namespace queue
{


    class QueueItem<TValue>
    {
        public TValue Value { get; set; }
        public QueueItem<TValue> Next { get; set; }
    }
    class Queue<TValue>
    {
        QueueItem<TValue> head;
        QueueItem<TValue> tail;
        public void Enqueue(TValue value)
        {
            var item = new QueueItem<TValue> { Value = value };
            if (head == null)
            {
                head = tail = item;
            }
            else
            {
                tail.Next = item;
                tail = item;
            }
        }

        public TValue Dequeue(){
            if(head==null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null) tail=null;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            for (int i = 0; i < 3; i++) queue.Enqueue(i);
            for (int i = 0; i < 3; i++) System.Console.WriteLine(queue.Dequeue());
        }
    }
}
