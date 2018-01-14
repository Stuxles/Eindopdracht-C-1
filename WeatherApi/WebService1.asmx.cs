using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WeatherApi

{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        const string Apikey = "4f8a18f314623f5db7cdf7f05deeecba";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public String[] CurrentWeather(String place)
        {
            using (WebClient wcumum = new WebClient())
            {
                string request = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=nl", place, Apikey);
                var jsonres = wcumum.DownloadString(request);
                var objectres = JsonConvert.DeserializeObject<OpenWeatherMap.RootObject>(jsonres);
                OpenWeatherMap.RootObject resultobj = objectres;
                var arr1 = new string[] { resultobj.Name, resultobj.Weather[0].Description, resultobj.Main.Temp.ToString(), resultobj.Main.Humidity.ToString(), resultobj.Wind.Speed.ToString(), "http://openweathermap.org/img/w/" + resultobj.Weather[0].Icon + ".png" };
                return arr1;
            }
        }

        [WebMethod]
        public String[] Forecast(String place)
        {
            using (WebClient wcumum = new WebClient())
            {
                string request = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}&units=metric&lang=nl", place, Apikey);
                var jsonres = wcumum.DownloadString(request);
                var objectres = JsonConvert.DeserializeObject<Forecastmap.RootObject>(jsonres);
                Forecastmap.RootObject resultobj = objectres;
                var arr2 = new string[] {resultobj.List[0].Main.Temp.ToString()};
                return arr2;
            }
            
        }

        public class OpenWeatherMap
        {
            public class Weather
            {
                public int Id { get; set; }
                public string Main { get; set; }
                public string Description { get; set; }
                public string Icon { get; set; }
            }

            public class Main
            {
                public double Temp { get; set; }
                public int Humidity { get; set; }
            }

            public class Wind
            {
                public double Speed { get; set; }
                public int Deg { get; set; }
            }

            public class RootObject
            {
                public List<Weather> Weather { get; set; }
                public string Base { get; set; }
                public Main Main { get; set; }
                public int Visibility { get; set; }
                public Wind Wind { get; set; }
                public int Dt { get; set; }
                public int Id { get; set; }
                public string Name { get; set; }
                public int Cod { get; set; }
            }
        }

        public class Forecastmap
        {
            public class Main
            {
                public double Temp { get; set; }
            }

            public class List
            {
                public int Dt { get; set; }
                public Main Main { get; set; }
            }

            public class RootObject
            {
                public List<List> List { get; set; }
            }
        }
    }
}
