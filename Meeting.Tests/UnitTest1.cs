using System;
using Xunit;
using Meeting.Controllers;

namespace Meeting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            

            var controller = new WeatherForecastController(null);
            Assert.IsType<Int32>(controller.Get());
        }
    }
}
