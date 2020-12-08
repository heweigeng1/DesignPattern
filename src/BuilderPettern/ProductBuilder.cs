using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPettern
{
    public class ProductBuilder : AbstractBuilder
    {

        public override void UseCombined(Product product, CombinedProductTemplate template)
        {
            if (template!=null)
            {
                product.Details = template.Details;
            }
        }

        public override void UseVirtual(Product product, VirtualProductTemplate template)
        {
            if (template!=null)
            {
                product.CardNumber = template.CardNumber;
            }
        }
    }
}
