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
            sorter = choice switch
            {
                1 => new BubbleSort(),
                2 => new SelectionSort(),
                3 => new InsertionSort(),
                4 => new MergeSort(),
                5 => new QuickSort(),
                6 => new HeapSort(),
                _ => throw new ArgumentException("Invalid choice. Choose between 1 and 6.")
            };
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
