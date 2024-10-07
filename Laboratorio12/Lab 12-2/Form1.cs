using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las notas desde las cajas de texto
                double nota1 = Convert.ToDouble(textBox1.Text);
                double nota2 = Convert.ToDouble(textBox2.Text);
                double nota3 = Convert.ToDouble(textBox3.Text);

                // Calcular el promedio
                double promedio = (nota1 + nota2 + nota3) / 3;

                // Mostrar el promedio en la caja de texto de resultado
                textBox4.Text = promedio.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar las cajas de texto y el resultado
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
