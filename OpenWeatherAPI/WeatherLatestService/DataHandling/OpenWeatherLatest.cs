using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWeatherAPI.WeatherLatestService.DataHandling
{
    class OpenWeatherLatest
    {
        public LatestWeatherModel LatestForecast { get; set; }

        // Method that creates the above object following passing in the response from the API
        public void DeserializeLatestRates(string LatestForecastResponse)
        {
            LatestForecast = JsonConvert.DeserializeObject<LatestWeatherModel>(LatestForecastResponse);
        }
    }
}
