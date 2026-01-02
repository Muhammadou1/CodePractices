namespace nCopiesofFirst3Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NCoppiesOfString("Python", 2));  // Output: PytPyt
            Console.WriteLine(NCoppiesOfString("Python", 3));  // Output: PytPytPyt
            Console.WriteLine(NCoppiesOfString("JS", 3));      // Output: JSJSJS
            Console.ReadLine();                    // Keeping the console window open
        }

        public static string NCoppiesOfString(string str, int letterCounts)
        {
            int first3Letters = 3;
            string result = "";

            if (first3Letters > str.Length)
            {
                first3Letters = str.Length;
            }

            string front = str.Substring(0, first3Letters);
            for (int i = 0; i < letterCounts; i++)
            {
                result += front;
            }
            return result;

        }


    }
}
