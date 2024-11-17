using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Laboratorio19_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected async void btnGetById_Click(object sender, EventArgs e)
        {
            try
            {
                string data = await GetValueByIdAsync(2); // ID específico a buscar
                lblDataById.Text = data; // Muestra el dato obtenido en el Label.
            }
            catch (Exception ex)
            {
                lblDataById.Text = "Error: " + ex.Message;
            }
        }

        private async Task<string> GetValueByIdAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                // Asegúrate de que el puerto de la API esté configurado correctamente.
                client.BaseAddress = new Uri("https://localhost:44360/");
                HttpResponseMessage response = await client.GetAsync($"api/values/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data;
                }
                else
                {
                    throw new Exception("Error al obtener el dato con ID " + id);
                }
            }
        }
    }
}
