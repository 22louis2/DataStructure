﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to perform");

            // Getting the user to input the size the array they need in order to use the Stack and Queue Generic class
            Console.WriteLine("1. Stack \t\t 2. Queue \t\t 3. LinkedList\t\t\n");
            int reply = Convert.ToInt32(Console.ReadLine());
            if(reply == 1 || reply == 2) {
                Console.Write("  Enter the Size you want to set your array to : ");
                int max = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[max];
            }

            Stack<int> stack = new Stack<int>();

            Queue<int> queue = new Queue<int>();

            LinkedList<string> linkedlist = new LinkedList<string>();

            /***********************************************************/
            // RUN ON WINDOWS POWERSHELL OR COMMAND PROMPT
            /**********************************************************/

            //Console.WriteLine(linkedlist.isEmpty());
            //Console.WriteLine(linkedlist.Size());
            //linkedlist.Add("test1");
            //linkedlist.Add("test2");
            //linkedlist.Insert(1, "test3");
            //Console.WriteLine(linkedlist.Size());

            //Console.WriteLine(linkedlist.Search("test1"));
            //linkedlist.Remove("test3");
            //Console.WriteLine(linkedlist.Size());
            //linkedlist.Index("test3");

            //linkedlist.Check("test2");
            //Console.WriteLine(linkedlist.Size());

            //Console.WriteLine(stack.isEmpty());
            //stack.Push(arr, max, 10);
            //Console.WriteLine(stack.isEmpty());
            //stack.Push(arr, max, 20);
            //stack.Push(arr, max, 30);
            //stack.Push(arr, max, 40);
            //stack.Push(arr, max, 50);
            //stack.Print(arr);
            //stack.Size();
            //stack.Peek(arr);
            //stack.Pop(arr);
            //stack.Peek(arr);
            //stack.Print(arr);
            //stack.Size();

            //Console.WriteLine(queue.isEmpty());
            //queue.Enqueue(arr, max, 10);
            //queue.isEmpty();
            //queue.Enqueue(arr, max, 20);
            //queue.Enqueue(arr, max, 30);
            //queue.Enqueue(arr, max, 40);
            //queue.Enqueue(arr, max, 50);
            //queue.Enqueue(arr, max, 66);
            //queue.Enqueue(arr, max, 98);
            //queue.Print(arr);
            //queue.Size();
            //queue.Dequeue(arr);
            //queue.Dequeue(arr);
            //queue.Dequeue(arr);
            //queue.Print(arr);
            //queue.Size();
            //queue.Enqueue(arr, max, 40);
            //queue.Enqueue(arr, max, 50);
            //queue.Enqueue(arr, max, 66);
            //queue.Enqueue(arr, max, 98);

            //queue.Print(arr);
            //queue.Size();



            Console.ReadLine();

        }        
    }
}
