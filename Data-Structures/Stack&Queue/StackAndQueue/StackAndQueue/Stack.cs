using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        private Node? _top;
        protected int _size;

        public Stack()
        {
            _top = null;
            _size = 0;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = _top;
            _top = newNode;
            _size++;
        }

        public int Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int value = _top.Value;
            _top = _top.Next;
            _size--;
            return value;
        }

        public int Peek()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _top.Value;
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
            Node? current = _top;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
