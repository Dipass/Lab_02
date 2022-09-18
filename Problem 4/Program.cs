using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,last,start;
            Console.Write("Select last word : ");
            last = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Sieve of Eratosthenes: ");
            for (start=1;start<last;start++)
            {
                int no=0;
                for(i=2;i <start;i++)
                {
                    if (start % 2 == 0)
                    {
                        no++;
                    }  
                }
                
                if (no == 0 && start != 1)
                {
                    Console.Write("{0} ", start);
                }
            }    
        }
    }
}
