using System.Linq;
using System.Xml.Linq;

namespace DictionaryC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , string> fruitCount = new Dictionary<int , string>();

            fruitCount.Add(1, "Apple");
            fruitCount.Add(2, "Mangoe");
            fruitCount.Add(3, "Orange");
            fruitCount[4] = "Banana";

            fruitCount.Add(5, "Kiwi");

            foreach (KeyValuePair<int, string> input in fruitCount)
            {
                Console.WriteLine($"Id:{input.Key} Fruit:{input.Value} ");
            }

            
        }
  
    }
}


