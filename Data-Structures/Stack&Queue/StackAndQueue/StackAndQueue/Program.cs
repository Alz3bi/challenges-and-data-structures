namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);
            stackWithReverse.Push(2);
            stackWithReverse.Push(3);
            stackWithReverse.Print();
            stackWithReverse.ReverseStack();
            Console.WriteLine("----------------------------------");
            stackWithReverse.Print();
        }
    }
}
