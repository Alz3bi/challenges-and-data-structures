using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                return;
            }
            int middle = (_size % 2 == 0) ? (_size / 2 - 1) : (_size / 2);
            Stack tempStack = new Stack();
            for (int i = 0; i < middle; i++)
            {
                tempStack.Push(Pop());
            }
            Pop();
            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop());
            }
        }
    }
}
