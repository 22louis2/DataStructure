using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedList<T>
    {
        public Node<T> head = null;
        public int Count { get; set; }
        public object Data { get; set; }

        public LinkedList()
        {
            this.head = null;
            this.Count = 0;
        }

        public bool isEmpty()
        {
            return this.Count == 0; 
        }

        public int Size()
        {
            return this.Count; 
        }
        
        public void Insert(int index, T data)
        {
            var current = this.head;
            int position = 0;
            var prevNode = new Node<T>(data);
            var node = new Node<T>(data);

            while ( position < index)
            {
                position++;
                prevNode = current;
                current = current.Next;
            }
            prevNode.Next = node;
            node.Next = current;
            this.Count++;
            Console.WriteLine($"Item {node.Data} has been inserted");
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            var current = this.head;
            if (this.head == null)
            {
                this.head = new Node<T>(data);
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current = node;
            }
            this.Count++;
            Console.WriteLine($"The Item {data} has been added");
        }

        public void Remove(T value)
        {
            var current = this.head;
            var prevNode = new Node<T>(value);
            while (!current.Data.Equals(value))
            {
                prevNode = current;
                current = current.Next;
            }
            prevNode.Next = current.Next;
            this.Count--;
        }

        //public void Clear()
        //{
        //    this.head = null;
        //    this.Count = 0;
        //}

        public int Index(T data)
        {
            try
            {
                Node<T> current = this.head;
                int position = 0;
            
                while(!current.Data.Equals(data))
                {
                    position++;
                    current = current.Next;
                }
                Console.WriteLine($"The Item is at position: {position}");
                return position;
            } catch (NullReferenceException)
            {
                Console.WriteLine("Item not found");
                return -1;
            }

        }

        public bool Check(T data)
        {
            return this.Index(data) >= 0;
        }

        public string Search(T value)
        {
            var current = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                if (current.Data.Equals(value))
                {
                    return $"Found: {current.Data}";
                }
                else
                {
                    current = current.Next;
                }

            }

            return "Item Not found";
        }

    }
}
