namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Print();
            list.Includes(3);
            list.Includes(6);
            list.Remove(3);
            list.Print();
            list.Includes(3);
        }
    }
}
