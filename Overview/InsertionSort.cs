using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class InsertionSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                /* Move elements of arr[0..i-1], that are
               greater than key, to one position ahead
               of their current position */
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
