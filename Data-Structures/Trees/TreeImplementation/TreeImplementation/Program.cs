namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Add nodes to the BST
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);
            bst.Add(4);
            bst.Add(12);
            bst.Add(17);
            bst.Print(); // 15 10 7 5
            Console.WriteLine("-------------------------------");

            // Check if a node exists
            bool contains = bst.Contains(7); // contains: true
            Console.WriteLine("contains 7: " + contains);
            Console.WriteLine("-------------------------------");

            // Remove a node
            bst.Remove(5);
            bst.Print(); // 15 10 7
            Console.WriteLine("-------------------------------");

            // Check if the node is removed
            contains = bst.Contains(5); // contains: false
            Console.WriteLine("contains 5: " + contains);
            Console.WriteLine("-------------------------------");

        }
    }
}
