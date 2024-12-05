using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico.DAL
{
    public class TicketRepositorio
    {
        private string connectionString;

        public TicketRepositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SoporteTecnicoConnectionString"].ConnectionString;
        }

        public List<Ticket> ObtenerTickets(string estadoFiltro)
        {
            List<Ticket> tickets = new List<Ticket>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT t.*, u.Nombre AS UsuarioNombre, t2.Nombre AS TecnicoNombre 
                    FROM Tickets t
                    LEFT JOIN Usuarios u ON t.UsuarioID = u.UsuarioID
                    LEFT JOIN Usuarios t2 ON t.TecnicoAsignadoID = t2.UsuarioID
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(estadoFiltro))
                {
                    query += " AND t.Estado = @Estado";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(estadoFiltro))
                    {
                        command.Parameters.AddWithValue("@Estado", estadoFiltro);
                    }

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
    }
}