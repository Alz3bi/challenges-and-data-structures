using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MinimumDepthTests
    {
        [Fact]
        public void MultipleNodes()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            int minDepth = Btree.FindMinimumDepth();
            Assert.Equal(2, minDepth);
        }
        [Fact]
        public void EmptyTree()
        {
            BinaryTree Btree = new BinaryTree();
            int minDepth = Btree.FindMinimumDepth();
            Assert.Equal(0, minDepth);
        }
    }
}
