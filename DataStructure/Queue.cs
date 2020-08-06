using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Queue<T>
    {
        // Data or properties needed to be accessed by this class
        public int Max { get; set; }
        public T[] Data { get; set; }
        public int Top { get; set; }
        public T Value { get; set; }

        // Queue constructor
        public Queue()
        {
            this.Top = -1;
        }

        // To check if the Queue is empty or not
        public bool isEmpty()
        {
            Console.Write("  ");
            if (Top < 0) return true;
            return false;
        }

        // Enables the adding of an item into the queue
        public string Enqueue(T[] data, int max, T value)
        {
            this.Data = data;
            this.Max = max;
            this.Value = value;
            if (Top >= (Max - 1))
            {
                return "  Queue is full\n";
            }
            else
            {
                Data[++Top] = Value;
                return $"  The Value Enqueued into the Queue is {Value}\n";
            }
        }

        // Used to remove the first element on the Queue
        public void Dequeue(T[] data)
        {
            this.Data = data;
            if (Top < 0)
            {
                Console.WriteLine("  The Queue is empty\n");
                return;
            }
            else
            {
                Console.WriteLine($"  The Item removed is {Data[0]}\n");
                for (int i = 0; i < Top; i++)
                {
                    Data[i] = Data[i+1];
                }
                Value = Data[Top--];

                return;
            }
        }
        // To print out all the data stored on the Queue
        public void Print(T[] data)
        {
            this.Data = data;
            if (Top < 0)
            {
                Console.WriteLine("  Queue is empty\n");
                return;
            }
            else
            {
                Console.WriteLine("  Queue contains: \n");
                for (int i = Top; i >= 0; i--)
                {
                    Console.WriteLine($"   |{Data[i]}|    ");
                    Console.WriteLine($"   ----   ");
                }
            }
        }
        // This is to keep track of size of the Queue as it changes
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

            Console.WriteLine($"  The size of the Queue is: {result + 1}\n");
            return;
        }


    }
}
