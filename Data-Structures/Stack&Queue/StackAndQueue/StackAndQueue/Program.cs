namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.DeleteMiddle();
            stack.Print();
        }
    }
}
