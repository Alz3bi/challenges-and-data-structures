using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MirrorTree
    {
        [Fact]
        public void MirrorTreeTest()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            // Act
            Btree.MirrorTree();

            // Assert
            List<int> mirroredInorder = Btree.InOrderTraversal();
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }
        [Fact]
        public void MirrorTreeEmptyTreeTest()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            Btree.MirrorTree();

            // Assert
            List<int> mirroredInorder = Btree.InOrderTraversal();
            Assert.Empty(mirroredInorder);
        }
        [Fact]
        public void MirrorTreeSingleNodeTest()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);

            // Act
            Btree.MirrorTree();

            // Assert
            List<int> mirroredInorder = Btree.InOrderTraversal();
            Assert.Equal(new List<int> { 4 }, mirroredInorder);
        }
    }
}
