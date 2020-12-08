using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPettern
{
    public class Product
    {
        public string Name { get; set; }

        public string CardNumber { get; set; }

        public string Pic { get; set; }

        public decimal Money { get; set; }

        public List<string> Details { get; set; }

    }
}
