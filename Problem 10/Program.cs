using System;

namespace Problem_10
{
    internal class Program
    {
        static int Difference(int[] arr, int n, int k)
        {
            int Dif = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (arr[i] - arr[j] == k || arr[j] - arr[i] == k)
                    {
                        Console.WriteLine("Pairs by Difference : [{0}  {1}]", arr[i], arr[j]);
                        Dif++;
                    }
                }
            }
            return Dif;
        }

        static void Main()
        {
            int[] arr = {1,2,3,4,5,6};
            int n=arr.Length;
            int k = 3;

            Console.WriteLine( Difference(arr, n, k) + " - the number of pairs with a difference");


        }

       
    }
}
