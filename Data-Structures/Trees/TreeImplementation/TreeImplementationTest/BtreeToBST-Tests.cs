using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;
using Xunit;

namespace TreeImplementationTest
{
    public class BtreeToBST_Tests
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
        public void ConvertToBST_Test()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(30);
            Btree.Root.Right = new Node(15);
            Btree.Root.Left.Left = new Node(20);
            Btree.Root.Right.Right = new Node(5);

            // Act
            Btree.ConvertToBST();
            string output = CaptureConsoleOutput(() => Btree.InOrder());

            // Assert
            Assert.Equal("5\r\n10\r\n15\r\n20\r\n30", output);
        }

        [Fact]
        public void ConvertToBST_OnlyLeftNodes_Test()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(8);
            Btree.Root.Left.Left = new Node(6);
            Btree.Root.Left.Left.Left = new Node(4);

            // Act
            Btree.ConvertToBST();
            string output = CaptureConsoleOutput(() => Btree.InOrder());

            // Assert
            Assert.Equal("4\r\n6\r\n8\r\n10", output);
        }

        [Fact]
        public void ConvertToBST_OnlyRightNodes_Test()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Right = new Node(12);
            Btree.Root.Right.Right = new Node(14);
            Btree.Root.Right.Right.Right = new Node(16);

            // Act
            Btree.ConvertToBST();
            string output = CaptureConsoleOutput(() => Btree.InOrder());

            // Assert
            Assert.Equal("10\r\n12\r\n14\r\n16", output);
        }
    }
}
