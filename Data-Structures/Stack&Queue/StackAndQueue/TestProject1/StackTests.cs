using StackAndQueue;
namespace TestProject1
{
    public class StackTests
    {
        [Fact]
        public void PushTest()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(1);

            // Assert
            Assert.Equal(1, stack.Peek());
        }
        [Fact]
        public void PopTest()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            // Act
            stack.Pop();

            // Assert
            Assert.Equal(1, stack.Peek());
        }
        [Fact]
        public void IsEmptyTest()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }
        [Fact]
        public void StackWithReverseTest()
        {
            // Arrange
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);
            stackWithReverse.Push(2);
            stackWithReverse.Push(3);

            // Act
            stackWithReverse.ReverseStack();

            // Assert
            Assert.Equal(1, stackWithReverse.Pop());
            Assert.Equal(2, stackWithReverse.Pop());
            Assert.Equal(3, stackWithReverse.Pop());
        }
        [Fact]
        public void StackWithReverseEmptyTest()
        {
            // Arrange
            StackWithReverse stackWithReverse = new StackWithReverse();

            // Act
            stackWithReverse.ReverseStack();

            // Assert
            Assert.True(stackWithReverse.IsEmpty());
        }
        [Fact]
        public void StackWithReverseOneElementTest()
        {
            // Arrange
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);

            // Act
            stackWithReverse.ReverseStack();

            // Assert
            Assert.Equal(1, stackWithReverse.Pop());
        }
        [Fact]
        public void StackWithDeleteMiddleEvenTest()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(4, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void StackWithDeleteMiddleOddTest()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(5, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.True(stack.IsEmpty());
        }
    }

}