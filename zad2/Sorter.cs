using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Sorter
    {
        public static void InsertionSort<T, TKey>(List<T> listToSort, Func<T, TKey> keySelector) 
            where TKey : IComparable<TKey>
        {
            for (int i = 1; i < listToSort.Count; i++)
            {
                T key = listToSort[i];
                TKey keyValue = keySelector(key);
                int j = i - 1;
                while (j >= 0 && keySelector(listToSort[j]).CompareTo(keyValue) > 0)
                {
                    listToSort[j + 1] = listToSort[j];
                    j--;
                }
                listToSort[j + 1] = key;
            }
        }

    }
}
