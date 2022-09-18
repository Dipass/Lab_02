using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main()
        {
            int length1, length2, count = 0;

            Console.WriteLine("Enter a length of the first word: ");
            length1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a length of the second word: ");
            length2 = Convert.ToInt32(Console.ReadLine());

            int shortLength = length1 < length2 ? length1 : length2;
            char[] arr1 = new char[length1];
            char[] arr2 = new char[length2];

            Console.WriteLine("Enter the first word: ");
            for(int i = 0; i < length1; i++)
            {
                arr1[i] = Convert.ToChar(Console.ReadLine());      
            }

            Console.WriteLine("Enter the second word: ");
            for (int i = 0; i < length2; i++)
            {
                arr2[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < shortLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                    continue;
                }
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("First worrd: " + String.Join("", arr1));
                    Console.WriteLine("Second worrd: " + String.Join("", arr2));
                    break;
                }
                else
                {
                    Console.WriteLine("Second worrd: " + String.Join("", arr2));
                    Console.WriteLine("First worrd: " + String.Join("", arr1));
                    break;
                }
            }

            if (count == shortLength) 
            {
                if (shortLength == length1)
                {
                    Console.WriteLine("First worrd: " + String.Join("", arr1));
                    Console.WriteLine("Second worrd: " + String.Join("", arr2));
                }
                else
                {
                    Console.WriteLine("Second worrd: " + String.Join("", arr2));
                    Console.WriteLine("First worrd: " + String.Join("", arr1));
                }
            }
        }
    }
}