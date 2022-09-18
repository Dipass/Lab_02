using System;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text2 = "abcdefghijklmnopqrstuvwxyz, ,0123456789";
            for (int q = 0; q < text2.Length; q++)
            {
                Console.WriteLine("Ведіть букву:");
                char word = char.Parse(Console.ReadLine());
                int i = 0;
                foreach (char w in text2)
                {
                    if (w == word) Console.WriteLine("Your word index " + i);
                    i++;
                }
            }
        }
    }
}
