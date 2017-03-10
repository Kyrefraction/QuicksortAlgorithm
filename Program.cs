using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" }; // make the array of strings

            int[] unsortedints = { 10, 2, 1, 4, 3, 6, 8, 7 }; // make the array of ints

            char[] unsortedchars = { 'a', 'z', 'y', 'c' };

            Console.WriteLine("Unsorted array of Strings");
            PrintArray(unsorted); // print the unsorted string array
            Quicksort(unsorted, 0, unsorted.Length - 1); // sort the strings
            Space(); // space
            Console.WriteLine("Sorted array of Strings");
            PrintArray(unsorted); // print the sorted string array
            Space(); // space

            Console.WriteLine("Unsorted array of Integers");
            PrintArray(unsortedints); // print unsorted array of integers
            Quicksort(unsortedints, 0, unsortedints.Length - 1); // sort the integers
            Space(); //space
            Console.WriteLine("Sorted array of Integers");
            PrintArray(unsortedints); // print the sorted integers
            Space();

            Console.WriteLine("Unsorted array of Chars");
            PrintArray(unsortedchars); // print the unsorted string array
            Space();
            Quicksort(unsortedchars, 0, unsortedchars.Length - 1); // sort the strings
            Console.WriteLine("sorted array of chars");
            PrintArray(unsortedchars);
            Space(); // space
            Console.ReadLine();
        }
        public static void Space() // just makes 2 spaces
        {
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void PrintArray<T>(T[] arrayToPrint) // prints the array sent in
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i] + " "); //write out on one line
            }
        }

        static void Quicksort<T>(T[] items, int left, int right) where T : IComparable<T> //quicksort algorithm
        {
            int i, j;
            i = left; j = right;
            T pivot = items[left];
            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i < right); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j > left); j--) ;
                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }
            if (left < j) Quicksort(items, left, j);
            if (i < right) Quicksort(items, i, right);
        }

        static void swap<T>(ref T a, ref T b)
        {
            T temp = a; // make 'a' a temporary variable
            a = b; // a becomes b
            b = temp; // b becomes the temp variable (a's inital value)
        }
    }
}
