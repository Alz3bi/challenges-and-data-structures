using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace TestProject1
{
    public class MinStackTests
    {
        [Fact]
        public void MinStackTest()
        {
            // Arrange
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act
            int min = minStack.GetMin();

            // Assert
            Assert.Equal(3, min);
        }
        [Fact]
        public void MinStackAfterPopTest()
        {
            // Arrange
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act
            minStack.Pop();
            int min = minStack.GetMin();

            // Assert
            Assert.Equal(7, min);
        }
        [Fact]
        public void MinStackAfterPushTest()
        {
            // Arrange
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act
            minStack.Push(2);
            int min = minStack.GetMin();

            // Assert
            Assert.Equal(2, min);
        }
    }
}
