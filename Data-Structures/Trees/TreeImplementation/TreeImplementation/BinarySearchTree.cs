using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Root = Add(Root, value);
        }
        private Node Add(Node? node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }
            if (value < node.Value)
            {
                node.Left = Add(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Add(node.Right, value);
            }
            return node;
        }
        public bool Contains(int value)
        {
            return Contains(Root, value);
        }
        private bool Contains(Node? node, int value)
        {
            if (node == null)
            {
                return false;
            }
            if (value == node.Value)
            {
                return true;
            }
            if (value < node.Value)
            {
                return Contains(node.Left, value);
            }
            return Contains(node.Right, value);
        }
        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }
        private Node? Remove(Node? node, int value)
        {
            if (node == null)
            {
                return null;
            }
            if (value == node.Value)
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }
                node.Value = MinValue(node.Right);
                node.Right = Remove(node.Right, node.Value);
            }
            else if (value < node.Value)
            {
                node.Left = Remove(node.Left, value);
            }
            else
            {
                node.Right = Remove(node.Right, value);
            }
            return node;
        }
        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}
