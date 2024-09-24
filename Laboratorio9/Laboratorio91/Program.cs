using System;

namespace Laboratorio91
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal precio = SolicitarPrecio();
            string formaDePago = SolicitarFormaDePago();

            if (formaDePago == "tarjeta")
            {
                string numeroCuenta = SolicitarNumeroDeCuenta();
                Console.WriteLine($"El producto tiene un precio de {precio:C} y será pagado con tarjeta (número de cuenta: {numeroCuenta}).");
            }
            else if (formaDePago == "efectivo")
            {
                Console.WriteLine($"El producto tiene un precio de {precio:C} y será pagado en efectivo.");
            }
            else
            {
                Console.WriteLine("Forma de pago no válida.");
            }
        }

        static decimal SolicitarPrecio()
        {
            decimal precio;
            do
            {
                Console.Write("Ingrese el precio del producto (valor positivo): ");
            } while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0);

            return precio;
        }

        static string SolicitarFormaDePago()
        {
            string formaDePago;
            do
            {
                Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
                formaDePago = Console.ReadLine().ToLower();
            } while (formaDePago != "efectivo" && formaDePago != "tarjeta");

            return formaDePago;
        }

        static string SolicitarNumeroDeCuenta()
        {
            string numeroCuenta;
            do
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                numeroCuenta = Console.ReadLine();
            } while (numeroCuenta.Length != 16 || !long.TryParse(numeroCuenta, out _));

            return numeroCuenta;
        }
    }
}

