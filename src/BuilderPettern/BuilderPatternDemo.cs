using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPettern
{
    public class BuilderPatternDemo
    {
        public void Test()
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
                new VirtualProductTemplate { CardNumber = "B312893718947" });
            Console.WriteLine(defaultPd.CardNumber);
            Console.ReadKey();
        }
    }
}
