using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;



namespace Generics
{
    public static class GenericsExtensions
    {
        static void MainFn(string[] args)
        {
            var queue = new Queue<string>();
            for(int i = 0; i < 10; i++)
            {
                queue.Enqueue(i.ToString());
            }
            queue.Dequeue();// deque 0
            queue.Dequeue();// deque 1
            foreach (var  item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains("3"));//checks for item in queue
            Console.WriteLine(queue.ToArray().GetType());//single checks for one element in array 
        }
    }
}
