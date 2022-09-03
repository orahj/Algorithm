using System;
using System.Collections.Generic;

namespace QueueDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue data structure uses the first in first out approach. FIFO. It is useful whn you need to process data in order. It contains element
            //in the order they were added
            // items added from the end and removed in front.
            Console.WriteLine("Hello World!");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(10);
            queue.Enqueue(20);

            int removedItem = queue.Dequeue();

            Console.WriteLine(removedItem);

            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.Peek());

            int current;

            while(queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }
        }
    }
}
