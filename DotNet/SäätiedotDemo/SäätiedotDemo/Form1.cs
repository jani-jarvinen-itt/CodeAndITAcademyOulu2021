using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SäätiedotDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lisääButton_Click(object sender, EventArgs e)
        {
            string kaupunki = kaupunkiTextBox.Text;
            if (kaupunki != "")
            {
                valitutListBox.Items.Add(kaupunki);
            }
        }

        private async void haeButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            StringBuilder tulokset = new StringBuilder();

            foreach (string kaupinki in valitutListBox.Items)
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={kaupinki}&appid=f9463bc94dd7f584483b04a3a49f18ba&units=metric";
                string json = await client.GetStringAsync(url);

                OpenWeatherMapApi data = JsonConvert.DeserializeObject<OpenWeatherMapApi>(json);
                string lämpötila = data.main.temp;
                tulokset.AppendLine($"Lämpötila kaupungissa {kaupinki}: {lämpötila}°C");
            }

            tuloksetTextBox.Text = tulokset.ToString();
        }
    }
}
