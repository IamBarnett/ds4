using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            // Obtener los números desde los TextBox
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            // Sumar los números
            int resultado = numero1 + numero2;

            // Mostrar el resultado en el Label
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
    }
}