using System;

namespace Loops4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i , j;

            for (i = 1; i < 6; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
