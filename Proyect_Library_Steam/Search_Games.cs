using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Proyect_Library_Steam
{
    public partial class Search_Games : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        string peticion = "https://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key=3E2E7C7FAF3ABB815F4E40B636929B64&appid=";
        public Search_Games()
        {
            InitializeComponent();
        }

        private async void BrnSearch_Click(object sender, EventArgs e)
        {
            string url = peticion + TextAppID.Text + "&format=json";

            try
            {
                string json = await httpClient.GetStringAsync(url);
                MessageBox.Show(json);

                using JsonDocument doc = JsonDocument.Parse(json);

                var stats = doc.RootElement
                    .GetProperty("game")
                    .GetProperty("availableGameStats")
                    .GetProperty("achievements");


                foreach (var stat in stats.EnumerateArray())
                {
                    string name = stat.GetProperty("name").GetString();
                    string displayName = stat.GetProperty("displayName").GetString();
                    double defaultValue = stat.GetProperty("defaultvalue").GetDouble();

                    // Asegúrate de que el número de columnas coincida con lo que agregas
                    DataGridLogros.Rows.Add(name, displayName,defaultValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener logros: {ex.Message}");
            }
        }
    }
}