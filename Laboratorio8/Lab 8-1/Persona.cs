namespace Lab_8_1
{
    public class Persona
    {
        public string Nombre;
        public int Edad;
        public string NIF;

        void Cumpleanos()
        {
            Edad++;
        }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }
}