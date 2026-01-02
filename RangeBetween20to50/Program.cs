namespace RangeBetween20to50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 51;
            //int num2 = 19;
            //int num3 = 53;
            Console.WriteLine(Range20To50(11, 20, 12));
            Console.WriteLine(Range20To50(30, 30, 17));
            Console.WriteLine(Range20To50(25, 35, 50));
            Console.WriteLine(Range20To50(15, 12, 8));
            Console.ReadLine();
            //while (true)
            //{
            //    Console.WriteLine("Enter firstNum ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter secondNum ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter thirdNum ");
            //    int num3 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(Range20To50(num1, num2, num3));
            //}
           
            
        }
        public static bool Range20To50(int x, int y, int z)
        {
            //int highestRange = 50;
            //int lowestRange = 20;

            //if (x <= highestRange && x >= lowestRange)
            //{
            //    return true;
            //}
            //else if (y <= highestRange && y >= lowestRange)
            //{
            //    return true;
            //}
            //else if (z <= highestRange && z >= lowestRange)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (x >= 20 &&  x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);

            
        }


    }
}
