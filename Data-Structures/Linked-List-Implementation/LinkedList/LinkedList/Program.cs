namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(5);
            list.Add(4);
            list.Add(5);

            list.Print();
            Console.WriteLine($"check if 3 is in the list: {list.Includes(3)}");
            Console.WriteLine($"check if 6 is in the list: {list.Includes(6)}");
            list.Remove(3);
            list.Print();
            Console.WriteLine($"check if 3 is in the list: {list.Includes(3)}");
            list.RemoveDuplicates();
            list.Print();
        }
    }
}
