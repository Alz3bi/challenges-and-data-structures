using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace TestProject1
{
    public class QueueTests
    {
        [Fact]
        public void EnqueueTest()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            queue.Enqueue(1);

            // Assert
            Assert.Equal(1, queue.Peek());
        }
        [Fact]
        public void DequeueTest()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            queue.Dequeue();

            // Assert
            Assert.Equal(2, queue.Peek());
        }
        [Fact]
        public void IsEmptyTest()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            bool isEmpty = queue.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }
    }
}
