using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del estudiante:");
            float score = float.Parse(Console.ReadLine());

            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score}... --- Usted ha aprobado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score}... --- Usted ha reprobado, debe repetir");
            }
        }
    }
}