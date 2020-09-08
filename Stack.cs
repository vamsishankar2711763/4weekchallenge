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
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push('a');
            st.Push('b');
            st.Pop(); // Popping the element
            Console.WriteLine("Stack elements are ");
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
           
            Console.WriteLine("Element at the top is " + st.Peek());
            Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " +st.Count);
           
        }
    }
}
