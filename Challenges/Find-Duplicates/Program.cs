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
            int[] tempArray = new int[array.Length];
            int tempIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        bool isAlreadyAdded = false;
                        for (int k = 0; k < tempIndex; k++)
                        {
                            if (tempArray[k] == array[i])
                            {
                                isAlreadyAdded = true;
                                break;
                            }
                        }
                        if (!isAlreadyAdded)
                        {
                            tempArray[tempIndex++] = array[i];
                        }
                        break; // Move to the next element in the array
                    }
                }
            }

            // Copy duplicates to the final array
            int[] duplicates = new int[tempIndex];
            for (int i = 0; i < tempIndex; i++)
            {
                duplicates[i] = tempArray[i];
            }

            return duplicates;
        }
    }
}
