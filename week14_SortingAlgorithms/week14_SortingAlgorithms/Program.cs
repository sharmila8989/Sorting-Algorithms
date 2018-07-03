using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace week14_SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sTime, eTime;
            List<int> unsortedList = fileReader();
    
            //Insertion Sorting
            sTime = DateTime.Now;
            List<int> insertionSList = Sorting_Algo.InsertionSort(unsortedList);
            eTime = DateTime.Now;
            Console.WriteLine("The insertion Sorting : " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");

            // Shell Sorting
            sTime = DateTime.Now;
            List<int> shellSList = Sorting_Algo.ShellSort(unsortedList);
            eTime = DateTime.Now;
            Console.WriteLine("The shell Sorting : " + ((eTime -sTime).TotalMilliseconds) + "milliseconds");

            // Linear Search of greatest number in Insertion Sort
            sTime = DateTime.Now;
            int greatestNum = Sorting_Algo.LinearSearch(insertionSList);
            eTime = DateTime.Now;
            Console.WriteLine("The Linear Search for "+greatestNum+" of insertion sorted list took " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");

            // Linear Search of greatest number in Shell Sort
            sTime = DateTime.Now;
            int greatestNum2 = Sorting_Algo.LinearSearch(shellSList);
            eTime = DateTime.Now;
            Console.WriteLine("The Linear Search for " + greatestNum + " of shell sorted list took " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");


            // Binary Search of greatest number in Insertion Sort
            sTime = DateTime.Now;
            int index = Sorting_Algo.BinarySearch(insertionSList, greatestNum);
            eTime = DateTime.Now;
            Console.WriteLine("The Binary Search for " + greatestNum + " of insertion sorted list took " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");


            //Binary Search of greates number in Shell Sort
            sTime = DateTime.Now;
            int index1 = Sorting_Algo.BinarySearch(shellSList, greatestNum2);
            eTime = DateTime.Now;
            Console.WriteLine("The Binary Search for " + greatestNum + " of shell sorted list took " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");


            //Linear search of every 1500thnumber - insertion sorted List
            sTime = DateTime.Now;
            List<int> lSearch1500th = Sorting_Algo.LinearSearchEvery1500th(insertionSList);
            eTime = DateTime.Now;
            Console.WriteLine("The Linear Search for 1500th number Insertion sort took "  + ((eTime - sTime).TotalMilliseconds) + "milliseconds");


            //Linear search of every 1500thnumber - shell sorted List
            sTime = DateTime.Now;
            List<int> lSearch1500th_shel = Sorting_Algo.LinearSearchEvery1500th(shellSList);
            eTime = DateTime.Now;
            Console.WriteLine("The Linear Search for 1500th number Shell sort took " + ((eTime - sTime).TotalMilliseconds) + "milliseconds");

            // Press enter to exit
            Console.ReadKey(true);




        }

        static List<int> fileReader()
        {
            List<int> numList = new List<int>();

            string[] numArray = System.IO.File.ReadAllLines(@"C:\Users\sharm\Source\Repos\Sorting-Algorithms\unsorted_numbers.csv");
            List<string> nList = new List<string>(numArray);
            foreach (string s in nList)
            {
                int i = int.Parse(s);
                numList.Add(i);
            }
            return numList;
        }




    }
}
   