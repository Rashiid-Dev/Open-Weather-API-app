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

        //[Test]
        //public void WebCallSuccessCheck()
        //{
        //    // Lets check that we have success returning true, this will tell us whether we have successfully built our framework.
        //    Assert.That(weatherLatestForecast.openWeatherLatest.LatestForecast.success);
        //}

        [Test()]
        public void CheckCity()
        {
            StringAssert.IsMatch("Birmingham", (string)weatherLatestForecast.GetCity());
        }
    }
}
