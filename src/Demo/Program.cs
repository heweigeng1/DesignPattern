using BridgePattern;
using BuilderPettern;
using CompositePattern;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BridgePattern_Test();
            CompositePattern_Test();
            Console.ReadKey();
        }

        /// <summary>
        /// 建造者模式
        /// </summary>
        private static void BuilderPattern_Test()
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

        private static void BridgePattern_Test()
        {
            new Log(new DbLog(), "tom", "hello girl").Save();
            new Log(new FileLog(), "lili", "hello boy").Save();
        }

        private static void CompositePattern_Test()
        {
            new CompositeDemo().Use();
        }
    }
}
