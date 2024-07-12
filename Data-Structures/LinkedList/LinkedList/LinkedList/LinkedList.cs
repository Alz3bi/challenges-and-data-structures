using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node? Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }
        public bool Includes(int data)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    Console.WriteLine("True");
                    return true;
                }
                current = current.Next;
            }
            Console.WriteLine("False");
            return false;
        }
        public void Remove(int data)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Print()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
