using LinkedList;
namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveFromLast()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            // Act
            list.Remove(5);
            // Assert
            Assert.False(list.Includes(5));
        }
        [Fact]
        public void PrintList()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                list.Print();

                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                // Assert
                var expected = "1 2 3 4 5 \r\n";
                Assert.Equal(expected, sw.ToString());
            }
        }
    }
}