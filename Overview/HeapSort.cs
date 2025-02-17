using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class HeapSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0);
            }
        }

        private void Heapify(int[] array, int n, int i)
        {
            int largest = i, left = 2 * i + 1, right = 2 * i + 2;

            if (left < n && array[left] > array[largest]) largest = left;
            if (right < n && array[right] > array[largest]) largest = right;

            if (largest != i)
            {
                (array[i], array[largest]) = (array[largest], array[i]);
                Heapify(array, n, largest);
            }
        }

        //private void Heapify1(int[] array, int n, int i)
        //{
        //    while (true)
        //    {
        //        int largest = i;
        //        int left = 2 * i + 1;
        //        int right = 2 * i + 2;

        //        if (left < n && array[left] > array[largest])
        //            largest = left;

        //        if (right < n && array[right] > array[largest])
        //            largest = right;

        //        if (largest == i)
        //            break;

        //        (array[i], array[largest]) = (array[largest], array[i]);
        //        i = largest; // Преместваме i към новата позиция и продължаваме
        //    }
        //}

    }
}
