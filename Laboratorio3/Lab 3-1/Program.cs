using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;
        double resultado;

        Console.Write("Introduce el primer número (a): ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número (b): ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        resultado = CalculosMatematicos.Calcular(primerNumero, segundoNumero);

        Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es: {2}", primerNumero, segundoNumero, resultado);
    }
}

internal class CalculosMatematicos
{
    public static double Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }
}
