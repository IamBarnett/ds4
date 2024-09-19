namespace Lab_8_1
{
    public class Trabajador : Persona
    {
        public int Sueldo;
        public Trabajador(string nombre, int edad, string nif, int sueldo)
           : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }
    }
}