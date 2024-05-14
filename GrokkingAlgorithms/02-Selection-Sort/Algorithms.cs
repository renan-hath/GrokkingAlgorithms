using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.SelectionSort
{
    public class Algorithms
    {
        public static int FindSmallestItemIndex(List<int> list)
        {
            int smallestItem = list[0];
            int smallestItemIndex = 0;

            for (int i  = 1; i < list.Count; i++)
            {
                if (list[i] < smallestItem)
                {
                    smallestItem = list[i];
                    smallestItemIndex = i;
                }
            }

            return smallestItemIndex;
        }

        public static List<int> SelectionSort(List<int> list)
        {
            int listSize = list.Count;
            List<int> sortedList = new List<int>();

            for (int i = 0; i < listSize; i++)
            {
                int smallestItemIndex = FindSmallestItemIndex(list);
                int smallestItem = list[smallestItemIndex];
                sortedList.Add(list[smallestItemIndex]);
                list.RemoveAt(smallestItemIndex);
            }

            return sortedList;
        }
    }
}