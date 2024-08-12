using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class MinStack : Stack
    {
        private Stack _minStack;

        public MinStack()
        {
            _minStack = new Stack();
        }

        public new void Push(int data)
        {
            base.Push(data);
            if (_minStack.IsEmpty() || data <= _minStack.Peek())
            {
                _minStack.Push(data);
            }
        }

        public new int Pop()
        {
            int value = base.Pop();
            if (value == _minStack.Peek())
            {
                _minStack.Pop();
            }
            return value;
        }
        public int Top()
        {
            return base.Peek();
        }
        public new bool IsEmpty()
        {
            return base.IsEmpty();
        }
        public int GetMin()
        {
            if (_minStack.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _minStack.Peek();
        }
        public void PrintStack()
        {
            base.Print();
        }
    }
}
