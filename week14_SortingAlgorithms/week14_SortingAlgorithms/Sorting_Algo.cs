using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_SortingAlgorithms
{
    class Sorting_Algo
    {
        static List<int> InsertionSort(List<int> numberlist)
        {
            int count = numberlist.Count;

            for (int i = 1; i < count; i++)
            {
                int j = i;

                while ((j > 0) && (numberlist[j] < numberlist[j - 1]))
                {
                    int k = j - 1;
                    int temp = numberlist[k];
                    numberlist[k] = numberlist[j];
                    numberlist[j] = temp;

                    j--;
                }
            }
            return numberlist;
        }

        static List<int> ShellSort(List<int> numberlist)
        {
            // Algorithm sourced from http://www.csharpstar.com/shell-sort-csharp-program/
            int count = numberlist.Count;
            int gap = count / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < count; i++)
                {
                    int j = i + gap;
                    temp = numberlist[j];

                    while (j - gap >= 0 && temp < numberlist[j - gap])
                    {
                        numberlist[j] = numberlist[j - gap];
                        j = j - gap;
                    }

                    numberlist[j] = temp;
                }

                gap = gap / 2;
            }

            return numberlist;
        }

        static int LinearSearch(List<int> numberList, int num)
        {
            // Algorithm sourced from https://www.geeksforgeeks.org/linear-search/
            int i;
            for (i = 0; i < numberList.Count; i++)
                if (numberList[i] == num)
                    return i;
            return -1;
        }

        static int BinarySearch(List<int> numberList, int num)
        {
            int low = 0;
            int mid;
            int high = numberList.Count - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (numberList[mid] > num)
                {
                    high = mid - 1;
                }
                else if (numberList[mid] < num)
                {
                    low = mid + 1;
                }
                else if (numberList[mid] == num)
                {
                    return mid;
                }
            }
            return -1;
        }

    }
}
