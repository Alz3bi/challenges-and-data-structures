namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Peek();
            stack.Print();
            stack.IsEmpty();
            Console.WriteLine("----------------------------------");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Peek();
            queue.Print();
            queue.IsEmpty();

        }
    }
}
