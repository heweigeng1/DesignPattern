using Xunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPettern.Tests
{
    public class BuilderPatternDemoTests
    {
        [Theory(DisplayName = "建造者模式")]
        [InlineData("BN1234567890")]
        public void TestTest(string code)
        {
            var defaultPd = new Product
            {
                Name = "abc",
                Money = 100m,
                Pic = "/adsf/231/saf.png"
            };
            var bd = new ProductBuilder();
            new ProductHub().Construct(bd,
                defaultPd,
                null,
                new VirtualProductTemplate { CardNumber = code });
        }
    }
}