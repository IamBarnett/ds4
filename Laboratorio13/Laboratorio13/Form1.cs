﻿using System;
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select ProductName from[dbo].[Products]";
        }
    }
}
