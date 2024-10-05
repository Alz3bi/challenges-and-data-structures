using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void FunctionTest()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel);
        }

        [Fact]
        public void FunctionTest2()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);
            Btree.Root.Left.Left.Right = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel);
        }
    }
}
