using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Laboratorio192
{
    public partial class Default : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string data = await GetAllValuesAsync();
                    lblData.Text = data; // Muestra los datos obtenidos en el Label.
                }
                catch (Exception ex)
                {
                    lblData.Text = "Error: " + ex.Message;
                }
            }
        }

        private async Task<string> GetAllValuesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Reemplaza el puerto 44360 con el puerto de tu API si es diferente.
                client.BaseAddress = new Uri("https://localhost:44360/");
                HttpResponseMessage response = await client.GetAsync("api/values");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data;
                }
                else
                {
                    throw new Exception("Error al obtener los datos");
                }
            }
        }
    }
}
