using System;

namespace BuilderPettern
{
    public abstract class AbstractBuilder
    {
        public abstract void UseCombined(Product product, CombinedProductTemplate template);

        public abstract void UseVirtual(Product product, VirtualProductTemplate template);
    }
}
