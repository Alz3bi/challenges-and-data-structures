namespace Reverse_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string reversed = ReverseWords(input);
            System.Console.WriteLine(reversed);
        }
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
