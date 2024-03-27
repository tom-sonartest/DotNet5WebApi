using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNet5WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet5WebApi.Tests
{
    [TestClass()]
    public class WeatherForecastTests
    {
        [TestMethod()]
        public void IsFreezingTest()
        {
            var forecast = new WeatherForecast();
            forecast.TemperatureC = -6;
            Assert.IsTrue(forecast.IsFreezing());
        }
        
        [TestMethod()]
        public void IsNotFreezingTest()
        {
            var forecast = new WeatherForecast();
            forecast.TemperatureC = 6;
            Assert.IsFalse(forecast.IsFreezing());
        }

        // Test if 0 is considered freezing
        [TestMethod()] 
        public void IsZeroFreezingTest()
        {
            var forecast = new WeatherForecast();
            forecast.TemperatureC = 0;
            Assert.IsTrue(forecast.IsFreezing());
        }
    }
}