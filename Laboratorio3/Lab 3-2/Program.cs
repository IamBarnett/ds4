using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double radio, area;

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        area = CalculosMatematicos.CalculoArea(radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}

internal class CalculosMatematicos
{
    public static double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}
