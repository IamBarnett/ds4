using System;

namespace Laboratorio92
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es par.");
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} es divisible entre 3.");
                }
            }
        }
    }
}

