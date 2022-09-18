using System;

namespace Problem_2
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Array : ");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int k = 4;

            int[] first = new int[n] ;
            int[] second = new int[n];
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                   first[i] = arr[n + i - k] ;
                }
                else
                {
                    second[i] = arr[i - k];
                }
            }
            Console.WriteLine("Rotate Array : ");
            for (int i = 0; i < n; i++)
            {
                array[i] = first[i] + second[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum first Array and Rotate Array : ");
            int[] Sum = new int[n];
            for(int i = 0; i < n;i++)
            {
                Sum[i] = arr[i] + array[i];
                Console.Write(Sum[i] + " ");
            }
                
        }

        
        
    }
}
