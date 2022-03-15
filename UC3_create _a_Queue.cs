﻿using System;
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
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);


            foreach (int element in queue)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("peek value is " + queue.Peek());
            Console.ReadLine();

        }
    }
}

