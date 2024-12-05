using System;
using System.Web.UI.WebControls;
using SistemaSoporteTecnico.DAL;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico.Pages
{
    public partial class GestionTickets : System.Web.UI.Page
    {
        private TicketRepositorio _ticketRepositorio = new TicketRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTickets();
            }
        }

        private void CargarTickets()
        {
            try
            {
                string estadoFiltro = ddlFiltroEstado.SelectedValue;
                var tickets = _ticketRepositorio.ObtenerTickets(estadoFiltro);
                gvTickets.DataSource = tickets;
                gvTickets.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = $"Error al cargar tickets: {ex.Message}";
            }
        }

        protected void ddlFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTickets();
        }

        protected void gvTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ticketId = Convert.ToInt32(e.CommandArgument);

            switch (e.CommandName)
            {
                case "VerDetalle":
                    Response.Redirect($"DetalleTicket.aspx?id={ticketId}");
                    break;

                case "CambiarEstado":
                    // Lógica para cambiar estado
                    CambiarEstadoTicket(ticketId);
                    break;
            }
        }

        private void CambiarEstadoTicket(int ticketId)
        {
            try
            {
                // Implementar lógica de cambio de estado
                _ticketRepositorio.CambiarEstadoTicket(ticketId);
                CargarTickets();
                lblMensaje.Text = "Estado del ticket actualizado";
                lblMensaje.CssClass = "text-success";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = $"Error al cambiar estado: {ex.Message}";
                lblMensaje.CssClass = "text-danger";
            }
        }

        protected void btnCrearNuevoTicket_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearTicket.aspx");
        }
    }
}