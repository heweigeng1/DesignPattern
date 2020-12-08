using BuilderPettern;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
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
                new CombinedProductTemplate { Details = new System.Collections.Generic.List<string> { "abcd" } },
                new VirtualProductTemplate { CardNumber = "B312893718947" });
            Console.WriteLine(defaultPd.CardNumber);
            Console.ReadKey();
        }
    }
}
