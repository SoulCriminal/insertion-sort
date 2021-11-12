using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[6] { 22,27,16,2,18,6 };
         int n = 6, i, j, val, flag;
         Console.WriteLine("Insertion Sort");
         Console.Write("Initial array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         for (i = 1; i < n; i++) {
            val = arr[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) {
               if (val < arr[j]) {
                  arr[j + 1] = arr[j];
                  j--;
                  arr[j + 1] = val;
               }
               else flag = 1;
            }
         }
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         
        }
    }
}
