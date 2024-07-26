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
    }
}