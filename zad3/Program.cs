using System.Diagnostics;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortAlgorithm[] algorithms = new SortAlgorithm[]
            {
                    new MergeSort(),
                    new QuickSort()
            };

            while (true)
            {
                Console.Write("Enter elements count (0 to exit):");
                int elementsCount = int.Parse(Console.ReadLine());
                if (elementsCount == 0) break;

                int[] array = new int[elementsCount];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, elementsCount + 1);
                }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                algorithms[0].Sort(array);
                stopwatch.Stop();
                long mergeSortTime = stopwatch.ElapsedMilliseconds;

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, elementsCount + 1);
                }

                stopwatch.Restart();
                algorithms[1].Sort(array);
                stopwatch.Stop();
                long quickSortTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine($"Times for sorting of {elementsCount} elements:");
                Console.WriteLine($"Merge sort time: {mergeSortTime} ms");
                Console.WriteLine($"Quick sort time: {quickSortTime} ms");
            }
        }
    }
}
