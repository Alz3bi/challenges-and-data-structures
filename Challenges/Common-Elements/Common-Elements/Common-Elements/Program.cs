namespace Common_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };
            int[] commonElements = CommonElements(array1, array2);

            Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
        }

        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> common = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        if (!common.Contains(arr1[i]))
                        {
                            common.Add(arr1[i]);
                        }
                        break;
                    }
                }
            }

            return common.ToArray();
        }
    }
}
