using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Stacks_And_Queues
{
    public class Program
    {
        static void Main(string[] args)
        {
                Stack<int> st = new Stack<int>();

                st.Push(70);
                st.Push(30);
                st.Push(56);


                foreach (int ele in st)
                {
                    Console.WriteLine(ele);
                }
                Console.WriteLine("----------");
                Console.WriteLine(st.Peek());
            Console.ReadLine();
        }
    }
}

