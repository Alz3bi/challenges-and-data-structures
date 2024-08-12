using TreeImplementation;
namespace TreeImplementationTest
{
    public class BinaryTreeTests
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
        public void PreOrderTest()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            // Act
            string output1 = CaptureConsoleOutput(() => binaryTree.PreOrder());

            // Assert
            Assert.Equal("1\r\n2\r\n3", output1);
        }

        [Fact]
        public void InOrderTest()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);

            // Act
            string output2 = CaptureConsoleOutput(() => binaryTree.InOrder());

            // Assert
            Assert.Equal("2\r\n1\r\n3", output2);
        }

        [Fact]
        public void PostOrderTest()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);

            // Act
            string output3 = CaptureConsoleOutput(() => binaryTree.PostOrder());

            // Assert
            Assert.Equal("2\r\n3\r\n1", output3);
        }
    }
}