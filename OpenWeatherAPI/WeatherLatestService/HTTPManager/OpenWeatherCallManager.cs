using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace OpenWeatherAPI.WeatherLatestService.HTTPManager
{
    class OpenWeatherCallManager
    {
        private readonly IRestClient client;

        public OpenWeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetLatestForecast()
        {
            var request = new RestRequest("/weather" + AppConfigReader.Location + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
