using System;
using System.Collections;
using System.Collections.Generic;
namespace lazy_collections
{

    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

   

    public class Queue<T> : IEnumerable<T>
    {
         QueueItem<T> head;
        QueueItem<T> tail;
        public bool IsEmpty { get { return head == null; } }

        #region 
        public void Enqueue(T value)
        {
            if (IsEmpty)
                tail = head = new QueueItem<T> { Value = value, Next = null };
            else
            {
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T Deequeue()
        {
            if (head == null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;
        }


        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

         public class QueueEnumerator<T> : IEnumerator<T>
    {
        Queue<T> queue;
        QueueItem<T> item; // то, куда смотрим в настоящий момент

        public QueueEnumerator(Queue<T> queue){
            this.queue = queue;
            item = null;
        }

        // показывает на какой объект
        // в данный момент указывает преречеслитель
        public T Current 
        {
            get { return item.Value; }
        }
        public bool MoveNext()
        {
            if (item == null)
            item = queue.head;
            else 
            item=item.Next;
            return item != null;
        }
#region 
        object IEnumerator.Current => throw new NotImplementedException();


        public void Dispose()
        {
           
        }

        

        public void Reset()
        {
           
        }
        #endregion
    }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (!queue.IsEmpty)
                System.Console.WriteLine(queue.Deequeue());

            foreach (var value in queue)
                System.Console.WriteLine(value);

        }

    }

}

