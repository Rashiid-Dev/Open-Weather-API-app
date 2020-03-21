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
            OpenWeatherLatest.DeserializeLatestRates(lastForecast);
            json_forecast = JsonConvert.DeserializeObject<JObject>(lastForecast);
        }

        public bool CheckRateTypes()
        {
            foreach (KeyValuePair<string, JToken> rate in (JObject)json_forecast["forecast"])
            {
                if (rate.Value.Type != JTokenType.Float)
                {
                    Console.WriteLine(rate.Key);
                    if (rate.Key != "EUR")
                    {
                        Console.WriteLine(rate.Key);
                        return false;
                    }
                }
            }
            return true;
        }

        public int RatesCount()
        {
            var count = 0;
            foreach (var rate in json_forecast["rates"])
            {
                count++;
            }
            return count;
        }

        public JToken getBase()
        {
            Console.WriteLine(json_forecast["base"]);
            return json_forecast["base"];
        }
    }
}