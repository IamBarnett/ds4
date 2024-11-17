using System;
using System.Web.UI;

namespace Laboratorio20
{
    public partial class Default : Page
    {
        protected void btnShowTable_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number))
            {
                string table = "<br />";
                for (int i = 1; i <= 25; i++)
                {
                    table += $"{number} x {i} = {number * i}<br />";
                }
                lblTable.Text = table;
            }
            else
            {
                lblTable.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}
