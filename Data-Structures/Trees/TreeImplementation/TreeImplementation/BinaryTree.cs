using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node? Root { get; set; }

        public List<int> LargestLevelValue() {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return new List<int>();
            }

            List<int> result = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int max = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();
                    max = Math.Max(max, node.Value);

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                result.Add(max);
            }

            return result;
        }
        public int LeafSum()
        {
            return LeafSum(Root);
        }
        private int LeafSum(Node? node)
        {
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return node.Value;
            return LeafSum(node.Left) + LeafSum(node.Right);
        }
        public void FindSecondMax()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Node? secondMax = FindSecondMax(Root, null);
            if (secondMax == null)
            {
                Console.WriteLine("Second max does not exist.");
            }
            else
            {
                Console.WriteLine("Second max is: " + secondMax.Value);
            }
        }
        private Node? FindSecondMax(Node node, Node? parent)
        {
            if (node.Right != null)
            {
                return FindSecondMax(node.Right, node);
            }
            else if (node.Left != null)
            {
                return FindMax(node.Left);
            }
            else
            {
                return parent;
            }
        }

        private Node? FindMax(Node node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node;
        }
        public void MirrorTree()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }
            MirrorTree(Root);
        }
        private void MirrorTree(Node node)
        {
            if (node == null)
                return;

            MirrorTree(node.Left);
            MirrorTree(node.Right);

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
        public List<int> InOrderTraversal()
        {
            List<int> result = new List<int>();
            InOrderTraversal(Root, result);
            return result;
        }
        private void InOrderTraversal(Node? node, List<int> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Value);
                InOrderTraversal(node.Right, result);
            }
        }
        public void InOrder()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }
            InOrder(Root);
        }

        private void InOrder(Node? node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.WriteLine(node.Value);
                InOrder(node.Right);
            }
        }

        public void PreOrder()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }
            PreOrder(Root);
        }

        private void PreOrder(Node? node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void PostOrder()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }
            PostOrder(Root);
        }

        private void PostOrder(Node? node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.WriteLine(node.Value);
            }
        }
        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }
            Print(Root, 0, false);
        }
        private void Print(Node? node, int level, bool isRight)
        {
            if (node != null)
            {
                Print(node.Right, level + 1, true);

                if (level != 0)
                {
                    for (int i = 0; i < level - 1; i++)
                        Console.Write("|\t");

                    if (isRight)
                        Console.Write("|-------");
                    else
                        Console.Write("|-------");
                }

                Console.WriteLine(node.Value);

                Print(node.Left, level + 1, false);
            }
        }
        public void RightView()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();

                    if (i == levelSize - 1)
                    {
                        Console.Write(node.Value + " ");
                    }

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
        }
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return 0;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxNodes = 0;
            int maxLevel = 0;
            int currentLevel = 0;
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }
        public int FindMinimumDepth()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return 0;
            }

            Queue<(Node node, int depth)> queue = new Queue<(Node node, int depth)>();
            queue.Enqueue((Root, 1));

            while (queue.Count > 0)
            {
                var (node, depth) = queue.Dequeue();

                if (node.Left == null && node.Right == null)
                {
                    return depth;
                }

                if (node.Left != null)
                {
                    queue.Enqueue((node.Left, depth + 1));
                }

                if (node.Right != null)
                {
                    queue.Enqueue((node.Right, depth + 1));
                }
            }

            return 0;
        }
        public void ConvertToBST()
        {
            try
            {
                if (Root == null)
                    throw new InvalidOperationException("Tree is empty.");

                List<int> values = new List<int>();
                InOrderTraversal(Root, values);
                values.Sort();

                int index = 0;
                ConvertToBST(Root, values, ref index);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private void ConvertToBST(Node? node, List<int> values, ref int index)
        {
            if (node == null) return;

            ConvertToBST(node.Left, values, ref index);
            node.Value = values[index++];
            ConvertToBST(node.Right, values, ref index);
        }

    }
}
