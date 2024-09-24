using System;
using System.Collections.Generic;
using laboratorio94;

namespace laboratorio95
{
    class Program
    {
        static void Main(string[] args)
        {
            Aleatorios aleatorios = new Aleatorios();

            int numeroAleatorio = aleatorios.GenerarNumero(1, 100);
            Console.WriteLine($"Número aleatorio entre 1 y 100: {numeroAleatorio}");

            int[] arregloAleatorio = aleatorios.GenerarArreglo(1, 50, 10);
            Console.WriteLine("Arreglo de números aleatorios entre 1 y 50:");
            foreach (var numero in arregloAleatorio)
            {
                Console.WriteLine(numero);
            }

            int min = 1;
            int max = 50;
            int cantidad = 10;

            int[] arregloNoRepetidos = GenerarArregloNoRepetidos(aleatorios, min, max, cantidad);
            Console.WriteLine("Arreglo de números no repetidos entre 1 y 50:");
            foreach (var numero in arregloNoRepetidos)
            {
                Console.WriteLine(numero);
            }
        }

        private static int[] GenerarArregloNoRepetidos(Aleatorios aleatorios, int min, int max, int cantidad)
        {
            if (cantidad > (max - min + 1))
            {
                throw new ArgumentException("La cantidad solicitada excede el rango de números disponibles.");
            }

            HashSet<int> numerosUnicos = new HashSet<int>();
            while (numerosUnicos.Count < cantidad)
            {
                int numero = aleatorios.GenerarNumero(min, max);
                numerosUnicos.Add(numero); 
            }

            return new List<int>(numerosUnicos).ToArray(); 
        }
    }
}
