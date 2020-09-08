using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            Console.WriteLine("Queue elements are ");
            foreach (Object obj in queue)
            {
                Console.WriteLine(obj);
            }
           
            Console.WriteLine("First element of queue is " + queue.Peek());
            Console.WriteLine();
            Console.WriteLine("The number of elements in the stack "+queue.Count);
           
        }
    }
}
