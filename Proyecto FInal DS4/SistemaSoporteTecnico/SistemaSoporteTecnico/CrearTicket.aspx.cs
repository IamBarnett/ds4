using System;
using System.Web.UI;
using SistemaSoporteTecnico.DAL;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico
{
    public partial class CrearTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si hay usuario en sesión
            if (Session["UsuarioLogueado"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnCrearTicket_Click(object sender, EventArgs e)
        {
            Usuario usuarioActual = (Usuario)Session["UsuarioLogueado"];

            Ticket nuevoTicket = new Ticket
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                UsuarioID = usuarioActual.UsuarioID,
                Estado = "Nuevo"
            };

            TicketDAL ticketDAL = new TicketDAL();
            int ticketId = ticketDAL.CrearTicket(nuevoTicket);

            // Redirigir o mostrar mensaje de éxito
            Response.Redirect($"DetalleTicket.aspx?id={ticketId}");
        }
    }
}