using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        private Node? _front;
        private Node? _rear;
        private int _size;

        public Queue()
        {
            _front = null;
            _rear = null;
            _size = 0;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);

            if (_rear == null)
            {
                _front = newNode;
                _rear = newNode;
            }
            else
            {
                _rear.Next = newNode;
                _rear = newNode;
            }

            _size++;
        }

        public int Dequeue()
        {
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int value = _front.Value;
            _front = _front.Next;

            if (_front == null)
            {
                _rear = null;
            }

            _size--;
            return value;
        }

        public int Peek()
        {
            if (_front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _front.Value;
        }

        public int Size()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }
        public void Print()
        {
            Node? current = _front;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
