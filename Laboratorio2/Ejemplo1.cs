using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(String[] args)
        {
            Client client = new Client();
            //Ejemplo utilizando las variables de instancia de clase.
            client.FirstName = "Su_Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        //Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //utilizando variables de instancia dentro del metodo de la clase.
            return FirstName + "" + LastName;
        }
    }
}
