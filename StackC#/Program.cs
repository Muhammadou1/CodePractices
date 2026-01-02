using System.Collections;

namespace StackC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Stack<int> num = new Stack<int>();
            //num.Push(1);
            //num.Push(2);
            //num.Push(3);
            //num.Push(4);

            //using stack class
            Stack s = new Stack();
            s.Push("MJ");
            s.Push("MSD");
            s.Push("10");
            s.Push("2");

            s.Pop();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            ////Remove all
            //while(num.Count > 0)
            //{
            //    Console.WriteLine(num.Pop());
            //}

            ////View all element
            //Console.WriteLine("All element");
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            ////Remove top
            //num.Pop();
            //Console.WriteLine("After first pop");
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            ////Remove next top
            //num.Pop();
            //Console.WriteLine("After second pop");
            //foreach (int i in num)
            //{

            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}


        }
    }
}
