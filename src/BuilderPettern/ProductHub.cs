using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPettern
{
    public class ProductHub
    {
        public void Construct(AbstractBuilder abstractBuilder, Product product, CombinedProductTemplate cpt = null, VirtualProductTemplate vpt = null)
        {
            abstractBuilder.UseCombined(product, cpt);

            abstractBuilder.UseVirtual(product, vpt);
        }
    }
}
