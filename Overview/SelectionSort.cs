using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class SelectionSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                (array[i], array[minIndex]) = (array[minIndex], array[i]);

                //int temp = array[minIndex];
                //array[minIndex] = array[i];
                //array[i] = temp;

            }
        }
    }
}
