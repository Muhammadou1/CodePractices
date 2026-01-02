using System.Threading.Tasks.Dataflow;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            // return empty if length is 0 or null
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            // create a starting word point
            string baseWord = strs[0];
            // create empty string to stre prefix
            string prefix = "";
            //iterate through each character 
            for (int i = 0; i < baseWord.Length; i++)
            {
                // iterate through the next strings
                for (int j = 1; j < strs.Length; j++)
                {
                    // check if current index[i] is out of bound with current index[j]
                    // check if index[i][j] is diffrent from  strs[0] and strs[i]
                    if (i >= strs[j].Length || strs[j][i] != baseWord[i])
                        //return 
                        return prefix;
                }
                // join characters to prefix
                prefix += baseWord[i];
            }
            return prefix;



        }


    }
}
