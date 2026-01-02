namespace PalindromeNumber
{
    public class test{
        public bool? Result { get; set; } = null;
        public bool Expected { get; set; }
        public bool Pass { get { return (Result ?? false).Equals(Expected); } }
        public int Case { get; set; }
    }
    class runTest
    {
        public static void run(test[] tests) {
            foreach (var t in tests)
            {
                t.Result = Program.IsPalindrome(t.Case);
            }
        }
    }



    internal class Program
    {

        public static void render(test[] tests) {
            tests.ToList().ForEach(render);
        }
        public static void render(test t) {

            Console.WriteLine($"{t.Case}");
            Console.WriteLine($"Expected {t.Expected}    -----    Result {t.Result}");
            Console.WriteLine($"Pass? - {t.Pass}");
            Console.WriteLine("*************************************\n\n");
        }
        static void Main(string[] args)
        {
            test[] AllTestCases = {
                new() { Case = 1 , Expected = true},
                new() { Case = 0 , Expected = true},
                new() { Case = 5 , Expected = true},



                new() { Case = 121 , Expected = true},
                new() { Case = 10 , Expected = false},
                new() { Case = -4 , Expected = false},
                new() { Case = -1111, Expected = false},
                new() { Case = 110001 , Expected = false},
                new() { Case = 1234554321 , Expected = true},
                new() { Case = 123454321 , Expected = true}
            };

            runTest.run(AllTestCases);

            render(AllTestCases);


            //Console.WriteLine(IsPalindrome(10));
        
        }

        public static bool IsPalindrome(int x)
        {
            //if num < 0 or num % 10 = 0; return false
            if (x < 0 || (x > 0 && x % 10 == 0))
            {
                return false;
            }

            int reversedNum = 0;
            while (x > reversedNum)
            {
                //find last digit(remainder)
                int lastDigit = x % 10;
                //reversed number + last digit
                reversedNum = reversedNum * 10 + lastDigit;
                // remove last digit from originalNum
                x = x / 10;
            }
            // check if reversedNum == x || if reversedNum == to x / 10
            return x == reversedNum || x == reversedNum / 10;
        }


    }
}
