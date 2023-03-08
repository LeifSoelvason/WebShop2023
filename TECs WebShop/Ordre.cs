using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECs_WebShop
{
    public class Ordre
    {
        public int OrdreID { get; set; }

        public List<Produkt> MineProdukter { get; set; }

        public Decimal Total { get; set; }

    }
}