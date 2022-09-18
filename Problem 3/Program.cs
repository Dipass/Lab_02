using System;
using System.Linq;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of element: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[k * 4];
            int n=array.Length; 
            int[] mid = new int[k * 2];
            int[] start = new int[k];
            int[] end = new int[k];
            int[] result = new int[mid.Length];

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = n - k * 3 - 1, j = 0; i >= 0; i--, j++)
            {
                start[j] = array[i];
            }

            for (int i = n - k * 3, j = 0; j < mid.Length; i++, j++)
            {
                mid[j] = array[i];
            }

            for (int i = n - 1, j = 0; i >= array.Length - k; i--, j++)
            {
                end[j] = array[i];
            }

            int[] startEnd = start.Concat(end).ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = mid[i] + startEnd[i];
            }

            Console.WriteLine("Array => " + String.Join(", ", array));
            Console.WriteLine("Result => " + String.Join(", ", result));
        }
    }

}