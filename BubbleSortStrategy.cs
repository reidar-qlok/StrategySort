using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySort
{
    internal class BubbleSortStrategy : ISortStrategy
    {
        //Online cost is free
        public void Sort(List<int> data)
        {
            int n = data.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        // Swap elements
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the list is already sorted
                if (!swapped)
                    break;
            }
            Console.WriteLine("Sorting using Bubble Sort");
        }
    }
}
