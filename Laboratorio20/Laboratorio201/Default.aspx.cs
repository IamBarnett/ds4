using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio201
{
    public partial class Default : Page
    {
        protected void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            int n;
            // Verifica que el valor ingresado sea un número válido
            if (int.TryParse(txtSize.Text, out n) && n > 0)
            {
                pnlMatrix.Controls.Clear(); // Limpiar el contenido anterior

                Table matrixTable = new Table();
                matrixTable.BorderWidth = 1;

                // Crear la matriz dinámica N x N
                for (int i = 0; i < n; i++)
                {
                    TableRow row = new TableRow();
                    for (int j = 0; j < n; j++)
                    {
                        TableCell cell = new TableCell();
                        // Poner '1' en la diagonal inversa, '0' en el resto
                        cell.Text = (j == (n - i - 1)) ? "1" : "0";
                        cell.BorderWidth = 1;
                        row.Cells.Add(cell);
                    }
                    matrixTable.Rows.Add(row);
                }

                pnlMatrix.Controls.Add(matrixTable); // Agregar la tabla al panel
            }
            else
            {
                pnlMatrix.Controls.Add(new Literal { Text = "Por favor, ingrese un número válido mayor a 0." });
            }
        }
    }
}



