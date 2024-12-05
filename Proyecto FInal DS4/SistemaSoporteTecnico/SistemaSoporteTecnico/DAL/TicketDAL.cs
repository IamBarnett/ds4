using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico.DAL
{
    public class TicketDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SoporteTecnicoConnectionString"].ConnectionString;

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

        public Ticket ObtenerTicketPorId(int ticketId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT t.*, u.Nombre AS UsuarioNombre, t2.Nombre AS TecnicoNombre 
                    FROM Tickets t
                    LEFT JOIN Usuarios u ON t.UsuarioID = u.UsuarioID
                    LEFT JOIN Usuarios t2 ON t.TecnicoAsignadoID = t2.UsuarioID
                    WHERE t.TicketID = @TicketID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TicketID", ticketId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Ticket
                            {
                                TicketID = Convert.ToInt32(reader["TicketID"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaUltimaActualizacion = reader["FechaUltimaActualizacion"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["FechaUltimaActualizacion"])
                                    : (DateTime?)null,
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                UsuarioNombre = reader["UsuarioNombre"].ToString(),
                                TecnicoAsignadoID = reader["TecnicoAsignadoID"] != DBNull.Value
                                    ? Convert.ToInt32(reader["TecnicoAsignadoID"])
                                    : (int?)null,
                                TecnicoNombre = reader["TecnicoNombre"] != DBNull.Value
                                    ? reader["TecnicoNombre"].ToString()
                                    : null
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Ticket> ObtenerTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT t.*, u.Nombre AS UsuarioNombre, t2.Nombre AS TecnicoNombre 
                    FROM Tickets t
                    LEFT JOIN Usuarios u ON t.UsuarioID = u.UsuarioID
                    LEFT JOIN Usuarios t2 ON t.TecnicoAsignadoID = t2.UsuarioID
                    ORDER BY t.FechaCreacion DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tickets.Add(new Ticket
                            {
                                TicketID = Convert.ToInt32(reader["TicketID"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaUltimaActualizacion = reader["FechaUltimaActualizacion"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["FechaUltimaActualizacion"])
                                    : (DateTime?)null,
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                UsuarioNombre = reader["UsuarioNombre"].ToString(),
                                TecnicoAsignadoID = reader["TecnicoAsignadoID"] != DBNull.Value
                                    ? Convert.ToInt32(reader["TecnicoAsignadoID"])
                                    : (int?)null,
                                TecnicoNombre = reader["TecnicoNombre"] != DBNull.Value
                                    ? reader["TecnicoNombre"].ToString()
                                    : null
                            });
                        }
                    }
                }
            }
            return tickets;
        }

        public void CambiarEstadoTicket(int ticketId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Tickets 
                    SET Estado = 
                        CASE 
                            WHEN Estado = 'Nuevo' THEN 'En Progreso'
                            WHEN Estado = 'En Progreso' THEN 'Resuelto'
                            WHEN Estado = 'Resuelto' THEN 'Cerrado'
                            ELSE Estado 
                        END,
                    FechaUltimaActualizacion = GETDATE()
                    WHERE TicketID = @TicketID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TicketID", ticketId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
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