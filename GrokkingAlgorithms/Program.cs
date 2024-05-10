//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using GrokkingAlgorithms.IntroductionToAlgorithms;

namespace GrokkingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("======================");
            Console.WriteLine("Binary Search");
            Console.WriteLine("======================");
            Console.WriteLine();

            var list = new List<int> { 1, 3, 5, 7, 9 };

            // We expect a return of index 1 here, since that's where 3 is at.
            Console.WriteLine("First index returned: " + Algorithms.BinarySearch(list, 3));
            // And here, nothing! Since -1 isn't a part of the list.
            Console.WriteLine("Second index returned: " + Algorithms.BinarySearch(list, -1));
        }
    }
}