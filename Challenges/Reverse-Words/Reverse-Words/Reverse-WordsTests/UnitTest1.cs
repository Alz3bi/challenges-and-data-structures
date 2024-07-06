using Reverse_Words;
namespace Reverse_WordsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {  
            // Arrange
            string input = "csharp is programming language";
            string expected = "language programming is csharp";
            // Act
            string actual = Program.ReverseWords(input);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";
            // Act
            string actual = Program.ReverseWords(input);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            // Arrange
            string input = "challenges and data structures";
            string expected = "structures data and challenges";
            // Act
            string actual = Program.ReverseWords(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}