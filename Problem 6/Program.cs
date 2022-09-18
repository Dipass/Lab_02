using System;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3 };
            int n = arr.Length;
            int start = 1 , last=1,array=arr[0];
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    start++;
                }
                else
                {
                    start = 1;
                }

                if (start > last)
                {
                    last = start;
                    array = arr[i];
                }
            }

            Console.Write("Max Sequence of Equal Elements : ");
            for (int i = 0; i < last; i++)
            {
                Console.Write("{0} ",array);
            }
            }
        }
}
