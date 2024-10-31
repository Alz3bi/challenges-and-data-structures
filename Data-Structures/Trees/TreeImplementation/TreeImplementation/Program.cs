namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(30);
            Btree.Root.Right = new Node(15);
            Btree.Root.Left.Left = new Node(20);
            Btree.Root.Right.Right = new Node(5);

            Console.WriteLine("Original Tree (InOrder):");
            Btree.InOrder();

            Btree.ConvertToBST();

            Console.WriteLine("Converted BST (InOrder):");
            Btree.InOrder();

        }
    }
}
