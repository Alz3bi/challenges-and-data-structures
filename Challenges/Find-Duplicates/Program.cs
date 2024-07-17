namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 16, 20, 10, 16 };
            int[] duplicates = FindDuplicates(array);
            foreach (int value in duplicates)
            {
                Console.WriteLine(value);
            }
        }

        public static int[] FindDuplicates(int[] array)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int value in array)
            {
                if (!seen.Add(value))
                {
                    if(!duplicates.Contains(value))
                    {
                        duplicates.Add(value);
                    }
                }
            }
            return duplicates.ToArray();
        }
    }
}
