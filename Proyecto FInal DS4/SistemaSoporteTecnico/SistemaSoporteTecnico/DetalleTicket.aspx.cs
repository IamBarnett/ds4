using System;
using System.Web.UI;
using SistemaSoporteTecnico.DAL;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico
{
    public partial class DetalleTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si hay usuario en sesión
            if (Session["UsuarioLogueado"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                // Verificar si se proporcionó un ID de ticket
                if (int.TryParse(Request.QueryString["id"], out int ticketId))
                {
                    CargarDetallesTicket(ticketId);
                }
                else
                {
                    MostrarError("ID de ticket inválido.");
                }
            }
        }

        private void CargarDetallesTicket(int ticketId)
        {
            try
            {
                TicketDAL ticketDAL = new TicketDAL();
                Ticket ticket = ticketDAL.ObtenerTicketPorId(ticketId);

                if (ticket != null)
                {
                    lblTitulo.Text = ticket.Titulo;
                    lblDescripcion.Text = ticket.Descripcion;
                    lblEstado.Text = ticket.Estado;
                    lblFechaCreacion.Text = ticket.FechaCreacion.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    MostrarError("Ticket no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar detalles: {ex.Message}");
            }
        }

        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketId = int.Parse(Request.QueryString["id"]);
                TicketDAL ticketDAL = new TicketDAL();
                ticketDAL.CambiarEstadoTicket(ticketId);

                // Recargar los detalles del ticket
                CargarDetallesTicket(ticketId);
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cambiar estado: {ex.Message}");
            }
        }

        protected void btnIrGestionTickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionTickets.aspx");
        }

        private void MostrarError(string mensaje)
        {
            pnlDetalleTicket.Visible = false;
            pnlMensaje.Visible = true;
            lblMensaje.Text = mensaje;
        }
    }
}