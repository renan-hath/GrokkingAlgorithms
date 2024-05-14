using GrokkingAlgorithms.IntroductionToAlgorithms;
using GrokkingAlgorithms.SelectionSort;
using System.Diagnostics;

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
            Console.WriteLine("First index returned: " + IntroductionToAlgorithms.Algorithms.BinarySearch(list, 3));
            // And here, nothing! Since -1 isn't a part of the list.
            Console.WriteLine("Second index returned: " + IntroductionToAlgorithms.Algorithms.BinarySearch(list, -1));

            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("Selection Sort");
            Console.WriteLine("======================");
            Console.WriteLine();

            var list2 = new List<int> { 5, 3, 6, 2, 10 };

            // We expect a list of 2, 3, 5, 6, 10 here.
            Console.WriteLine(string.Join(", ", SelectionSort.Algorithms.SelectionSort(list2)));
        }
    }
}