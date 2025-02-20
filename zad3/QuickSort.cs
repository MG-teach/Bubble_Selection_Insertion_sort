using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class QuickSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            QuickSortRecursive(array, 0, array.Length - 1);
        }

        private void QuickSortRecursive(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSortRecursive(array, low, pi - 1);
                QuickSortRecursive(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                    (array[++i], array[j]) = (array[j], array[i]);
            }
            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            return i + 1;
        }
    }
}
