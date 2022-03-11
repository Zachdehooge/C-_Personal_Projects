using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Weather_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // You will need to go to openweathermap.org and sign up to get an API key
        string APIKey = "3a2614090e1bae9b1e848149f81cb42c";

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",City.Text,APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                double temperature = Info.main.temp;

                double tempFinal = (((temperature -273.15) * 9)/5) + 32;

                string temp = String.Format("{0:0}°F", tempFinal);

                long sunrise1 = Info.sys.sunrise;

                DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeSeconds(sunrise1);

                DateTime dateTime = dateTimeOffSet.DateTime.ToLocalTime();

                string sunrise2 = dateTime.ToString("hh:mm tt");

                long sunset1 = Info.sys.sunset;

                DateTimeOffset dateTimeOffSet1 = DateTimeOffset.FromUnixTimeSeconds(sunset1);

                DateTime dateTime1 = dateTimeOffSet1.DateTime.ToLocalTime();

                string sunset2 = dateTime1.ToString("hh:mm tt");

                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunrise.Text = sunrise2;
                labSunset.Text = sunset2;
                labTemp.Text = temp;

                labWind.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.temp.ToString();
            }
        }
    }
}
