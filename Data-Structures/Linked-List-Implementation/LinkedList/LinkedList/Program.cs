namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(4);
            //list.Add(5);
            //list.Add(3);
            //list.Add(5);
            //list.Add(4);
            //list.Add(5);

            //list.Print();
            //Console.WriteLine($"check if 3 is in the list: {list.Includes(3)}");
            //Console.WriteLine($"check if 6 is in the list: {list.Includes(6)}");
            //list.Remove(3);
            //list.Print();
            //Console.WriteLine($"check if 3 is in the list: {list.Includes(3)}");
            //list.RemoveDuplicates();
            //list.Print();

            LinkedList sortedList1 = new LinkedList();
            sortedList1.Add(1);
            sortedList1.Add(3);
            sortedList1.Add(5);

            LinkedList sortedList2 = new LinkedList();
            sortedList2.Add(2);
            sortedList2.Add(4);
            sortedList2.Add(6);

            Console.WriteLine("Printing the sorted list");
            LinkedList.MergeSortedLists(sortedList1, sortedList2).Print();
        }
    }
}
