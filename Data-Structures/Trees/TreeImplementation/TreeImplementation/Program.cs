namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            List<int> originalInorder = Btree.InOrderTraversal(); // Output: [12, 8, 9, 4, 7]
            foreach (var item in originalInorder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");

            Btree.MirrorTree();


            List<int> mirroredInorder = Btree.InOrderTraversal(); // Output: [7, 4, 9, 8, 12]
            foreach (var item in mirroredInorder)
            {
                Console.WriteLine(item);
            }


        }
    }
}
