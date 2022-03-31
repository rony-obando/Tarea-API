using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.IServices;
using Domain.Entities;
using Newtonsoft.Json; 

namespace AppClimate.Forms
{
    public partial class ClimateForm : Form
    {
        IWeatherServices weatherServices;
        public ClimateForm(IWeatherServices weather)
        {
            weatherServices = weather;
            InitializeComponent();
        }
        string apiKey = "2824a69890cc1539e8bf46e1d43167fc";

        private void ClimateForm_Load(object sender, EventArgs e)
        {

        }
        void GetClimate()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", Ciudadtxt.Text, apiKey);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    label2.Text = Info.weather[0].main;
                    label3.Text = Info.weather[0].description;
                    label9.Text = weatherServices.ConvertDateTime(Info.sys.sunset).ToShortTimeString() + " PM";
                    label8.Text = weatherServices.ConvertDateTime(Info.sys.sunrise).ToShortTimeString() + " AM";
                    label10.Text = Info.wind.speed.ToString();
                    label11.Text = Info.main.pressure.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            GetClimate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
