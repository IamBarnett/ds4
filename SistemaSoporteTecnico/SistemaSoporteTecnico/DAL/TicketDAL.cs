using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico.DAL
{
    public class TicketDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public int CrearTicket(Ticket ticket)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Tickets 
                    (Titulo, Descripcion, Estado, UsuarioID, FechaCreacion) 
                    VALUES (@Titulo, @Descripcion, @Estado, @UsuarioID, GETDATE());
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", ticket.Titulo);
                    command.Parameters.AddWithValue("@Descripcion", ticket.Descripcion);
                    command.Parameters.AddWithValue("@Estado", "Nuevo");
                    command.Parameters.AddWithValue("@UsuarioID", ticket.UsuarioID);

                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public List<Ticket> ObtenerTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tickets ORDER BY FechaCreacion DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tickets.Add(new Ticket
                            {
                                TicketID = reader.GetInt32(reader.GetOrdinal("TicketID")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado")),
                                FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                                UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID"))
                            });
                        }
                    }
                }
            }

            return tickets;
        }

        public void ActualizarEstadoTicket(int ticketId, string nuevoEstado, int tecnicoId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Tickets 
                    SET Estado = @Estado, 
                        TecnicoAsignadoID = @TecnicoID,
                        FechaUltimaActualizacion = GETDATE()
                    WHERE TicketID = @TicketID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Estado", nuevoEstado);
                    command.Parameters.AddWithValue("@TecnicoID", tecnicoId);
                    command.Parameters.AddWithValue("@TicketID", ticketId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}