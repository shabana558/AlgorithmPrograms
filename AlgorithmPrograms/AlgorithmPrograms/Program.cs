using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
               
                Console.WriteLine("1.Insertion Sort");
                Console.WriteLine("2.Bubble sort");
                Console.WriteLine("3.Merge sort");
                Console.WriteLine("4.Anagram problem");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                   
                    case 1:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 25,52,36,58,41 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);
                        break;
                    case 2:
                        int[] arr1 = {25,26,35,85,65};
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;
                    case 3:
                        int[] arr2 = { 32, 12, 9, 65, 24, 5 };
                        MergeSort.Sort(arr2, 0, arr2.Length - 1);
                        MergeSort.PrintArray(arr2);
                        break;
                    case 4:
                        Anagram.FindAnagram();
                        break;

                    default:
                        Console.WriteLine("Enter the valid option!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
        }
    }
}

