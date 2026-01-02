namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        public static int RomanToInt(string roman)
        {
            //itereate through each character
            //curent roman value
            //if statement Check for next roman value
            // variable to hold next val
            // substrct if current roman val is less than next
            // add current roman val

            Dictionary<char, int> romanNumMap = new Dictionary<char, int>();
            romanNumMap['I'] = 1;
            romanNumMap['V'] = 5;
            romanNumMap['X'] = 10;
            romanNumMap['L'] = 50;
            romanNumMap['C'] = 100;
            romanNumMap['D'] = 500;
            romanNumMap['M'] = 1000;



            int count = 0;
            //itereate through each character
            for (int i = 0; i < roman.Length; i++)
            {
                //curent roman value
                int currentVal = romanNumMap[roman[i]];

                //if statement Check for next roman value
                if (i + 1 < roman.Length)
                {
                    // variable to hold next val
                    int nextVal = romanNumMap[roman[i + 1]];

                    // substrct if current roman val is less than next
                    if (currentVal < nextVal)
                    {
                        count -= currentVal;
                        continue;
                    }
                }
                // add current roman val
                count += currentVal;
            }
            return count;
            

            //Dictionary<char, int> romanNumMap2 = new Dictionary<char, int>
            //{
            //    {'I', 1},
            //    {'V', 5},
            //    {'X', 10},
            //    {'L', 50},
            //    {'C', 100},
            //    {'D', 500},
            //    {'M', 1000},
            //};

            //int count = 0;
            //int prev = 0;
            //foreach(var c in roman)
            //{
            //    Console.WriteLine(c);
            //    int current = romanNumMap2[c];
            //    Console.WriteLine(romanNumMap2[c]);
            //    if (current > prev)
            //    {
            //            count += current - 2 * prev;
            //    }
            //    else
            //    {
            //        count += current;
            //    }
            //   prev = current;
            //}

            //return count;

           
        }
    }
}
