using System;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio202
{
    public partial class Default : System.Web.UI.Page
    {
        private string connectionString = "Server=localhost;Database=ProductosDB;Trusted_Connection=True;"; // Cambiar a tu conexión

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarCampos();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd;
                    if (string.IsNullOrEmpty(txtId.Text)) // Nuevo registro
                    {
                        cmd = new SqlCommand("INSERT INTO Productos (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)", connection);
                    }
                    else // Actualizar registro existente
                    {
                        cmd = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock WHERE Id = @Id", connection);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                    }

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Producto guardado exitosamente.');</script>");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE Id = @Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtId.Text = reader["Id"].ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtStock.Text = reader["Stock"].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('Producto no encontrado.');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE Id = @Id", connection);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Producto eliminado exitosamente.');</script>");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
    }
}
