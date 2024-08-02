using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackWithReverse : Stack
    {
        public void ReverseStack()
        {
            if (IsEmpty())
            {
                return;
            }
            Queue queue = new Queue();
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }
            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
    }
}
