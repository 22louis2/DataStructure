﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stack<T>
    {
        public int Max { get; set; }
        public T[] Data { get; set; }
        public int Top { get; set; }
        public T Value { get; set; }

        // Constructor of the stack class
        public Stack()
        {
            this.Top = -1;
        }

        // Checking if the Stack is empty or not
        public bool isEmpty()
        {
            Console.Write("  ");
            if (Top < 0) return true;
            return false;
        }

        // To add an element onto the Stack, from the end
        public string Push(T[] data, int max, T value)
        {
            this.Data = data;
            this.Max = max;
            this.Value = value;
            if (Top >= (Max - 1))
            {
                return "  Stack is full\n";
            }
            else
            {
                Data[++Top] = Value;
                return $"  The Value Pushed into the Stack is {Value}\n";
            }
        }

        // Removing an item or element from the end of the Stack
        public void Pop(T[] data)
        {
            this.Data = data;
            if (Top < 0) {
                Console.WriteLine("  The Array is empty\n");
                return;
            }
            else
            {
                Console.WriteLine($"  The Item removed is: {Data[Top]}\n");
                Value = Data[Top--];
            }
        }

        // To print out the element at the top of the stack
        public void Peek(T[] data)
        {
            this.Data = data;
            if (Top < 0)
            {
                Console.WriteLine("  Stack is empty\n");
            }
            else Console.WriteLine($"  This is the Item at the top of the Stack: {Data[Top]}\n");
        }

        // To print out all the item(s) stored on the Stack
        public void Print(T[] data)
        {
            this.Data = data;
            if (Top < 0)
            {
                Console.WriteLine("  Stack is empty\n");
                return;
            }
            else
            {
                Console.WriteLine("  Stack contains: \n");
                for (int i = Top; i >= 0; i--)
                {
                    Console.WriteLine($"   |{Data[i]}|    ");
                    Console.WriteLine($"   ----   ");
                }
            }
        }

        // Getting how many element(s) or item(s) on the Stack
        public void Size()
        {

            int result = 0;
            if (Top < 0)
            {
                Console.WriteLine("  Size is 0\n");
                return;
            }
            else
            {
                result = Top;
            }
            Console.Write($"  The size of the stack is: {result + 1} \n");
            return;
        }
    }
}
