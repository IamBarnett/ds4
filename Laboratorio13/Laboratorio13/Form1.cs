using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private string connectionString =
        @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
            ListItems();
            
        }

        private void ListItems()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "select ProductName from Products";

            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al consultar la tabla", ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
