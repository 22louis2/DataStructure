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

        // Constructor of the LinkedList class
        public LinkedList()
        {
            this.head = null;
            this.Count = 0;
        }

        // To check if the LinkedList is empty or not
        public bool isEmpty()
        {
            return this.Count == 0; 
        }

        // Getting the size or length of the LinkedList element
        public int Size()
        {
            return this.Count; 
        }
        
        /* To input the users data at any position on the LinkedList
         * Also checking if the position exist already
         * If the index input is above the size of the LinkedList
         * then storing it at the last index
        */
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

        /* Storing the data with reference to the next node on the LinkedList
           if it is null */
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

        /* Remove the data stored on the LinkedList 
           and reference the next to the  next Node on the LinkedList*/
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
        
        // Check if the data exist and return its position on the LinkedList
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

        // Verify if the value passed through the paramters exist or not
        public bool Check(T data)
        {
            return this.Index(data) >= 0;
        }

        // Search is a data exist and return the data back to the user
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
