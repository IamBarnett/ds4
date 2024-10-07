using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button(object sender, EventArgs e)
        {
            // Variables para la velocidad y el tiempo
            double velocidad = 0;
            double tiempo = 0;

            // Intentar convertir los valores de los TextBox a números
            bool isVelocidadValid = double.TryParse(textBox1.Text, out velocidad);
            bool isTiempoValid = double.TryParse(textBox2.Text, out tiempo);

            // Validar que ambos valores sean correctos
            if (isVelocidadValid && isTiempoValid)
            {
                // Calcular la distancia
                double distancia = velocidad * tiempo;

                // Mostrar el resultado en el textBox3
                textBox3.Text = $"{distancia} ";
            }
            else
            {
                // Mostrar un mensaje de error si los valores no son válidos
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        // Evento del botón 2 para limpiar los TextBox
        private void Button2(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        // Evento del botón 3 para salir de la aplicación
        private void Button3(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}
