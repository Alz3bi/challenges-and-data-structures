using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class RightViewtest
    {
        [Fact]
        public void RightViewTest()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Btree.RightView();
                string expected = "2 5 6 7 ";
                // Assert
                Assert.Equal(expected, sw.ToString());
            }
        }
        [Fact]
        public void RightViewTestTreeOnlyRightNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Right.Right.Right = new Node(7);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Btree.RightView();
                string expected = "2 5 6 7 ";
                // Assert
                Assert.Equal(expected, sw.ToString());
            }
        }
    }
}
