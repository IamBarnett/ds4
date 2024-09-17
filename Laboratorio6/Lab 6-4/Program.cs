class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso Negado - no cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso conseguido");
        }
    }
        static void Main(String[] args)
        {
            checkAge(15);
        }
    }
