using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write($"|{data}|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(T data)
        {
            if (next == null) next = new Node<T>(data);
            else next.AddToEnd(data);
        }
    }
}
