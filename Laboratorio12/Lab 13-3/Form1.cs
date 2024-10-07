using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los lados desde las cajas de texto
                double ladoA = Convert.ToDouble(textBox1.Text);
                double ladoB = Convert.ToDouble(textBox2.Text);
                double ladoC = Convert.ToDouble(textBox3.Text);

                // Calcular el semiperímetro
                double semiperimetro = (ladoA + ladoB + ladoC) / 2;

                // Mostrar el resultado en la caja de texto correspondiente
                textBox4.Text = semiperimetro.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para calcular el área del triángulo usando la fórmula de Herón
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los lados desde las cajas de texto
                double ladoA = Convert.ToDouble(textBox1.Text);
                double ladoB = Convert.ToDouble(textBox2.Text);
                double ladoC = Convert.ToDouble(textBox3.Text);

                // Calcular el semiperímetro
                double semiperimetro = (ladoA + ladoB + ladoC) / 2;

                // Calcular el área usando la fórmula de Herón
                double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                // Mostrar el resultado en la caja de texto correspondiente
                textBox5.Text = area.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para limpiar los campos
        private void button3_Click(object sender, EventArgs e)
        {
            // Limpiar las cajas de texto
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // Función para salir de la aplicación
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}