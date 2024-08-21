using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class SecondMaxTests
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
        public void second_max_exists()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(20);
            bst.Add(3);
            bst.Add(7);
            bst.Add(15);
            bst.Add(25);

            // Act
            string output = CaptureConsoleOutput(() => bst.FindSecondMax());

            // Assert
            Assert.Equal("Second max is: 20", output);
        }
        [Fact]
        public void secondMaxTest()
        {
            // Arrange
            BinaryTree bst = new BinaryTree();
            bst.Root = new Node(10);

            // Act
            string output = CaptureConsoleOutput(() => bst.FindSecondMax());

            // Assert
            Assert.Equal("Second max does not exist.", output);
        }
        [Fact]
        public void SecondMaxNegativeValuesTest()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(-10);
            bst.Add(-5);
            bst.Add(-20);
            bst.Add(-3);
            bst.Add(-7);
            bst.Add(-15);
            bst.Add(-25);

            // Act
            string output = CaptureConsoleOutput(() => bst.FindSecondMax());

            // Assert
            Assert.Equal("Second max is: -5", output);
        }
    }
}
