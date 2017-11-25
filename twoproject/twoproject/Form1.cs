using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WeatherApplication_2010
{
    public partial class Form1 : Form
    {
        List<String> nameList = new List<string>();
        const string APPID = "542ffd081e67f4512b705f89d2a611b2";
        //string cityName = "Hamburg";

        public Form1()
        {
            InitializeComponent();
            
            getweather("Nice"); // one day weather
            getforecast("Nice"); //more than one day
        }

        /*********************Weather Info******************************/
        void getweather(string city)
        {
            using (WebClient web = new System.Net.WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6",city, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                //lbl.celcius.Text = string.format("\u00B0")+"C";
                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_temp.Text = string.Format("{0}\u00B0" + "C", outPut.main.temp);

                picture_main.Image = setIcon(outPut.weather[0].icon);
            }
        }

        /*********************Weather Forecast******************************/
        void getforecast (string city)
        {
            int day = 5;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&appid={1}&units=metric&cnt={2}",city,APPID,day);
           
            using (WebClient web = new WebClient()) 
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = Object;

                //next day
                lbl_day_2.Text = string.Format("{0}", getDate(forecast.list[1].dt).DayOfWeek);//returning Day
                lbl_cond_2.Text = string.Format("{0}", forecast.list[1].weather[0].main); //weather condition
                lbl_des_2.Text = string.Format("{0}", forecast.list[1].weather[0].description); //weather description
                lbl_temp_2.Text = string.Format("{0}\u00B0" + "C", forecast.list[1].temp.day); //weather temperature
                lbl_wind_2.Text = string.Format("{0} km/h", forecast.list[1].speed); //weather wind speed

               
                //day after tomorrow
                lbl_day_3.Text = string.Format("{0}", getDate(forecast.list[2].dt).DayOfWeek);//returning Day
                lbl_cond_3.Text = string.Format("{0}", forecast.list[2].weather[0].main); //weather condition
                lbl_des_3.Text = string.Format("{0}", forecast.list[2].weather[0].description); //weather description
                lbl_temp_3.Text = string.Format("{0}\u00B0" + "C", forecast.list[2].temp.day); //weather temperature
                lbl_wind_3.Text = string.Format("{0} km/h", forecast.list[2].speed); //weather wind speed

                //weather icon
                picture_1.Image = setIcon(forecast.list[1].weather[0].icon);
                picture_2.Image = setIcon(forecast.list[2].weather[0].icon);

            }
        }

        /***************************************************/
        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }  // millisecound to DateTime method

        /***************************************************/
        //set weather icon into the the picture box using API
        Image setIcon(string iconID)
        {
            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID); // weather icon resource 
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
            }
        }


        /*********************Button Function******************************/
        //allowing user to enter the current city and get current weather
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_cityName.Text != "")
            {
                getweather(txt_cityName.Text);
                getforecast(txt_cityName.Text);
            }
        }

        //save weather condition to a text (file handling)//in bin
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_cityName.Text != "")
            {
                using (StreamWriter str = new StreamWriter("my_weather.txt"))
                {
                    str.WriteLine("City Name: " + lbl_cityName.Text);
                    str.WriteLine("Country Name: " + lbl_country.Text);
                    str.WriteLine("Temp Name: " + lbl_temp.Text);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }    
    }
}