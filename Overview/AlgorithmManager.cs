using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class AlgorithmManager
    {
        private int[] array;
        private SortAlgorithm sorter;
        private long sortTime;

        public AlgorithmManager(int choice)
        {
            array = new int[10000];
            FillArray();
            switch (choice)
            {
                case 1: 
                    sorter = new BubbleSort();
                    break;
                case 2: 
                    sorter = new SelectionSort();
                    break;
                case 3: 
                    sorter = new InsertionSort();
                    break;
                case 4: 
                    sorter = new MergeSort();
                    break;
                case 5: 
                    sorter = new QuickSort();
                    break;
                case 6: 
                    sorter = new HeapSort(); 
                    break;
            }
        }

        private void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1, 10001);
        }

        public void Sort()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            sorter.Sort(array);
            stopwatch.Stop();
            sortTime = stopwatch.ElapsedMilliseconds;
        }

        public void Report()
        {
            Console.WriteLine($"Sorting completed in {sortTime} ms.");
        }
    }
}
