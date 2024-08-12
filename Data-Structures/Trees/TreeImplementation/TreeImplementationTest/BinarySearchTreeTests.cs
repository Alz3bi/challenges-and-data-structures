using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinarySearchTreeTests
    {
        private string CaptureConsoleOutput(Action action)
        {
            var originalConsoleOut = Console.Out;
            try
            {
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    action();
                    return sw.ToString().Trim();
                }
            }
            finally
            {
                Console.SetOut(originalConsoleOut);
            }
        }

        [Fact]
        public void AddNodeTest()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();

            // Act
            bst.Add(10);

            // Assert
            string output = CaptureConsoleOutput(() => bst.Print());
            Assert.Equal("10", output);
        }
        [Fact]
        public void ContainsNodeTest()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);

            // Act
            bool contains = bst.Contains(10);

            // Assert
            Assert.True(contains);
        }
        [Fact]
        public void RemoveNodeTest()
        {
               // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);

            // Act
            bst.Remove(5);

            // Assert
            string output = CaptureConsoleOutput(() => bst.Print());
            Assert.Equal("10", output);
        }
    }
}
