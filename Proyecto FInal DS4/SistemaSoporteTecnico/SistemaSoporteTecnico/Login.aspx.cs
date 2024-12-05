using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSoporteTecnico.DAL;
using SistemaSoporteTecnico.Models;

namespace SistemaSoporteTecnico
{
    public partial class Login : System.Web.UI.Page
    {
        protected void LoginControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string email = LoginControl.UserName;
            string contrasena = LoginControl.Password;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Usuario usuario = usuarioDAL.ValidarUsuario(email, contrasena);

            if (usuario != null)
            {
                Session["UsuarioLogueado"] = usuario;

                // Redirigir según el rol
                if (usuario.Rol == "Administrador" || usuario.Rol == "Tecnico")
                {
                    Response.Redirect("GestionTickets.aspx");
                }
                else
                {
                    Response.Redirect("CrearTicket.aspx");
                }
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}