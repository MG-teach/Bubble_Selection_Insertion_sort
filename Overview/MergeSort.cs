using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class MergeSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            MergeSortRecursive(array, 0, array.Length - 1);
        }

        private void MergeSortRecursive(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortRecursive(array, left, mid);
                MergeSortRecursive(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int leftSize = mid - left + 1, rightSize = right - mid;
            int[] leftArr = new int[leftSize], rightArr = new int[rightSize];

            Array.Copy(array, left, leftArr, 0, leftSize);
            Array.Copy(array, mid + 1, rightArr, 0, rightSize);

            int i = 0, j = 0, k = left;
            while (i < leftSize && j < rightSize)
                array[k++] = (leftArr[i] <= rightArr[j]) ? leftArr[i++] : rightArr[j++];

            while (i < leftSize) array[k++] = leftArr[i++];
            while (j < rightSize) array[k++] = rightArr[j++];
        }
    }
}
