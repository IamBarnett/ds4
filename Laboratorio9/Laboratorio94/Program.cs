using System;

namespace laboratorio94
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
        }
    }
}

