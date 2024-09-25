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
        public Node? Tail { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public bool Includes(int data)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    //Console.WriteLine("True");
                    return true;
                }
                current = current.Next;
            }
            //Console.WriteLine("False");
            return false;
        }
        public void Remove(int data)
        {
            if (Head == null) return;

            if (Head.Data == data)
            {
                Head = Head.Next;
                if (Head == null) Tail = null;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null) Tail = current;
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
                Head = Tail = newNode;
            }
            else
            {
                Tail!.Next = newNode;
                Tail = newNode;
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
        public void RemoveDuplicates()
        {
            var seen = new HashSet<int>();
            Node? current = Head;
            Node? previous = null;
            while (current != null)
            {
                if (!seen.Add(current.Data)) 
                {
                    previous!.Next = current.Next;
                    if (current.Next == null) Tail = previous;
                }
                else
                {
                    previous = current;
                }
                current = current.Next;
            }
        }
        public int Count()
        {
            Node? current = Head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            LinkedList mergedList = new LinkedList();
            Node? current1 = list1.Head;
            Node? current2 = list2.Head;
            while (current1 != null && current2 != null)
            {
                if (current1.Data < current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }
            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }
            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }
            return mergedList;
        }
        public void RotateByK(int k)
        {
            if (Head == null || k == 0) return;

            Node? current = Head;
            int count = 1;
            while (count < k && current != null)
            {
                current = current.Next;
                count++;
            }
            if (current == null) return;

            Node? kthNode = current;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = Head;
            Head = kthNode.Next;
            kthNode.Next = null;
        }
    }
}
