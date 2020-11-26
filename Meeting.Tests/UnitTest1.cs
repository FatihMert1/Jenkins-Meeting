using System;
using Xunit;
using Meeting.Controllers;
using System.Collections.Generic;

namespace Meeting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            

            var controller = new WeatherForecastController(null);
            Assert.IsType<IEnumerable<WeatherForecast>>(controller.Get());
        }
    }
}
