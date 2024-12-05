using System;
using System.Data.SqlClient;
using System.Configuration;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico.DAL
{
    public class UsuarioDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public Usuario ValidarUsuario(string email, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE Email = @Email AND Contrasena = @Contrasena";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Rol = reader.GetString(reader.GetOrdinal("Rol"))
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}