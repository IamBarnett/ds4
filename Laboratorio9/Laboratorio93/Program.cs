using System;

namespace Laboratorio93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del primer lado: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del segundo lado: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del tercer lado: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (EsTriangulo(lado1, lado2, lado3))
            {
                string tipoTriangulo = ObtenerTipoTriangulo(lado1, lado2, lado3);
                Console.WriteLine($"Los lados ingresados forman un triángulo {tipoTriangulo}.");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo.");
            }
        }

        static bool EsTriangulo(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static string ObtenerTipoTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                return "isósceles";
            }
            else
            {
                return "escaleno";
            }
        }
    }
}
