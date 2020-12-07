using Xunit;
using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Tests
{
    public class SuperFactoryTests
    {
        [Theory(DisplayName = "抽象工厂模式")]
        [InlineData("Whistle")]
        [InlineData("Wheel")]
        [InlineData("Is Null")]
        public void CreateTest(string name)
        {
            if (name == "Whistle")
            {
                Assert.True(new SuperFactory().Create(name) is WhistleFactory, "ok");
            }
            if (name == "Wheel")
            {
                var fac = new SuperFactory().Create(name);

                Assert.True(fac is WheelFactory, "ok");

                fac.Wheel("TaxiWheel").Wheel();
            }
            if (name == "Is Null")
            {
                try
                {
                    new SuperFactory().Create(name);
                }
                catch (Exception ex)
                {
                    Assert.True(ex.Message == "fail", "创建失败");
                }
            }
        }
    }
}