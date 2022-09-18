using System;

namespace Problem_8
{
    internal class Program
    {

        static int MostFrequentNumber(int[] arr , int n)
        {
            Array.Sort(arr); 
            int array = arr[0],start=1,last=1;
            for(int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    start++;
                }
                else
                    start = 1;
                if(start>last)
                {
                    last= start;
                    array = arr[i - 1];
                }
            }

            return array;
        }
        static void Main(string[] args)
        {
            int[] arr = {2,3,5,5,6,1};
            int n = arr.Length;
            Console.WriteLine("Most Frequent Number : " + MostFrequentNumber(arr, n));
        }
    }
}
