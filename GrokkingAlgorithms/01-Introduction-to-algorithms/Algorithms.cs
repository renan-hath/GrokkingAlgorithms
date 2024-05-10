using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.IntroductionToAlgorithms
{
    public class Algorithms
    {
        public static int? BinarySearch(List<int> list, int item)
        {

            int minPosition = 0;
            int maxPosition = list.Count - 1;

            while (minPosition <= maxPosition)
            {
                int middlePosition = (minPosition + maxPosition) / 2;
                int guessedItem = list[middlePosition];

                if (guessedItem == item)
                {
                    return middlePosition;
                }
                else if (guessedItem > item)
                {
                    maxPosition = middlePosition - 1;
                }
                else
                {
                    minPosition = middlePosition + 1;
                }
            }

            return null;
        }
    }
}
