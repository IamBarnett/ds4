using System;

namespace SistemaSoporteTecnico.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public int UsuarioID { get; set; }
        public string UsuarioNombre { get; set; }
        public int? TecnicoAsignadoID { get; set; }
        public string TecnicoNombre { get; set; }
    }
}