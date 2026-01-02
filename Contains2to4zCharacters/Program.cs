namespace Contains2to4zCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasZCharacters("frizz")); 
            Console.WriteLine(HasZCharacters("zane"));  
            Console.WriteLine(HasZCharacters("Zazz"));  
            Console.WriteLine(HasZCharacters("false")); 
            Console.WriteLine(HasZCharacters("zzzz"));  
            Console.WriteLine(HasZCharacters("ZZZZ"));  
        }


        public static bool HasZCharacters(string text)
        {
            int count = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == 'z')
                {
                    count++;
                }
                if (count > 1 && count <= 4)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
