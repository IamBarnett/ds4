Module peso
    Sub Main()
        'declaracion de variables
        Dim M As Double
        Dim G As Double
        Dim P As Double

        'Ingresar valores a las variables
        G = 9.8
        Console.Write("Ingrese la masa del objeto:")
        M = Console.ReadLine

        'Realizar los procesos
        P = M * G

        'Mostrar Resultados
        Console.WriteLine("Peso del objeto: {0}", P)
        Console.ReadKey()

    End Sub

End Module
