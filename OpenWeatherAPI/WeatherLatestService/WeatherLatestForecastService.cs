﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.WeatherLatestService.DataHandling;
using OpenWeatherAPI.WeatherLatestService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPI.WeatherLatestService
{
    class WeatherLatestForecastService
    {
        public OpenWeatherCallManager openWeatherCallManager = new OpenWeatherCallManager();

        // Our instance of the DTO that transforms our data into the format of our model
        public OpenWeatherLatest openWeatherLatest = new OpenWeatherLatest();

        // The last set of rates retrieved
        public String lastForecast;

        // Rates converted to JObject so we manipulate later in useful methods
        public JObject json_forecast;

        public WeatherLatestForecastService()
        {
            lastForecast = openWeatherCallManager.GetLatestForecast();
            openWeatherLatest.DeserializeLatestRates(lastForecast);
            json_forecast = JsonConvert.DeserializeObject<JObject>(lastForecast);
        }


      

        public JToken GetCity()
        {

            return json_forecast["name"];
            
        }

        public JToken getBase()
        {
            Console.WriteLine(json_forecast["base"]);
            return json_forecast["base"];
        }

        public JToken GetCountry()
        {
            return json_forecast["sys"]["country"];
        }

        public string ReturnWeatherDescription()
        {
            return (string)json_forecast["weather"]["description"];
        }

        public List<string> ReturnLongitudeLattitude()
        {
            List<string> LongLattList = new List<string>();
            LongLattList.Add((string)json_forecast["coord"]["lon"]);
            LongLattList.Add((string)json_forecast["coord"]["lat"]);
            return LongLattList;
        }
    }
}
