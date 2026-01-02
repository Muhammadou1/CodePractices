using System.Text;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ReverseWords("")}");
            Console.WriteLine($"{ReverseWords("   ")}");
            Console.WriteLine($"{ReverseWords("a")}");
            Console.WriteLine($"{ReverseWords("  hello  world  ")}");
            Console.WriteLine($"{ReverseWords("the sky is blue")}");
        }


        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            string[] word = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(word);
            return string.Join(" ", word);


        }


    }
}
