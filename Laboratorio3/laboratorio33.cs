using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double lado1, lado2, perimetro;

        Console.Write("Introduce la longitud del primer lado del rectángulo: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la longitud del segundo lado del rectángulo: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        perimetro = CalculosMatematicos.CalcularPerimetroRectangulo(lado1, lado2);

        Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
    }
}

internal class CalculosMatematicos
{
    public static double CalcularPerimetroRectangulo(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}
