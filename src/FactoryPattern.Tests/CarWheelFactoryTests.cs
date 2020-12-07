using Xunit;
using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Tests
{
    public class CarWheelFactoryTests
    {
        [Theory(DisplayName ="工厂模式")]
        [InlineData("Bus")]
        [InlineData("Taxi")]
        [InlineData("PoliceCar")]
        [InlineData("Is Null")]

        public void CreateTest(string name)
        {
            try
            {
                new CarWheelFactory().CreateWhistle(name).Whistle();
            }
            catch (Exception ex)
            {
                Assert.True(ex.Message == "object is null" && name == "Is Null");
            }
        }
    }
}