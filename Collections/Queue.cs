using System;
using System.Collections.Generic;


namespace CollectionsAndGenerics.Collections
{
    class Queue
    {
        public static void ProcessQueue()
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Apple");
            myQueue.Enqueue("Banana");
            myQueue.Enqueue("Orange");

            while (myQueue.Count > 0)
            {
                string element = myQueue.Dequeue();
                Console.WriteLine("Processing element: " + element);

            }
        }
    }
}
