using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.WeatherLatestService.DataHandling;
using OpenWeatherAPI.WeatherLatestService.HTTPManager;
using NUnit.Framework;
using OpenWeatherAPI.WeatherLatestService;

namespace OpenWeatherAPI.ServiceTests
{
    public class WeatherLatestTests
    {

        private WeatherLatestForecastService weatherLatestForecast = new WeatherLatestForecastService();

        [Test]
        public void WebCallSuccessCheck()
        { 
            Assert.AreEqual("200", (string)weatherLatestForecast.json_forecast["cod"]);
        }

        [Test]
        public void CheckReturnedCity()
        {
            StringAssert.IsMatch("Birmingham", (string)weatherLatestForecast.GetCity());
        }

        [Test]
        public void CheckReturnedCountry()
        {
            StringAssert.IsMatch("GB", (string)weatherLatestForecast.GetCountry());
        }

        [Test]
        public void CheckReturnedLatLongListCountIsTwo()
        {
            Assert.AreEqual(2, weatherLatestForecast.ReturnLongitudeLattitude().Count());
        }

        [Test]
        public void ConfirmReturnedLongitude()
        {
            StringAssert.IsMatch("-1.9", weatherLatestForecast.ReturnLongitudeLattitude()[0]);
        }

        [Test]
        public void ConfirmReturnedLattitude()
        {
            StringAssert.IsMatch("52.48", weatherLatestForecast.ReturnLongitudeLattitude()[1]);
        }
    }
}
