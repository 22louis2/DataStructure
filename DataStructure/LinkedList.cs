using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedList<T>
    {
        public Node<T> headNode;
        public LinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(T data)
        {
            if (headNode == null) headNode = new Node<T>(data);
            else headNode.AddToEnd(data);
        }

        public void AddToBeginning(T data)
        {
            if (headNode == null) headNode = new Node<T>(data);
            else
            {
                Node<T> temp = new Node<T>(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void RemoveFromBeginning()
        {
            if (headNode == null) return;
            else
            {
                headNode = headNode.next;
            }
        }

        public void RemoveFromEnd()
        {

        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

    }
}
