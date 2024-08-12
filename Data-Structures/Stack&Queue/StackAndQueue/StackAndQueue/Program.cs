namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            // Push elements
            minStack.Push(15); // Top -> 15 (min: 15)
            minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
            minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
            minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 

            // Print the stack
            minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15
            Console.WriteLine("--------------------------------------");

            // Get the minimum element
            int min = minStack.GetMin(); // min: 3
            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine("--------------------------------------");

            // Pop a node from the stack
            int popped = minStack.Pop(); // popped: 3
            minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15
            Console.WriteLine("--------------------------------------");

            // Get the new minimum element
            min = minStack.GetMin(); // min: 7
            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine("--------------------------------------");

            // Peek the top node
            int peeked = minStack.Top(); // peeked: 12
            Console.WriteLine($"Top element: {peeked}");
            Console.WriteLine("--------------------------------------");

            // Push another element
            minStack.Push(2);  // Top -> 2 -> 12 -> 7 -> 15 (min: 2)
            minStack.PrintStack(); // Output: Top -> 2 -> 12 -> 7 -> 15
            Console.WriteLine("--------------------------------------");

            // Get the new minimum element
            min = minStack.GetMin(); // min: 2
            Console.WriteLine($"Minimum element: {min}");
            Console.WriteLine("--------------------------------------");

            // Check if the stack is empty
            bool isEmpty = minStack.IsEmpty(); // isEmpty: false
            Console.WriteLine($"Is the stack empty? {isEmpty}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
