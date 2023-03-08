using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECs_WebShop
{
    public class Indkøbskurv
    {
        public List<Produkt> Produkter { get; set; }

        public Indkøbskurv()
        {
            Produkter = new List<Produkt>();
        }

        public void TilføjProdukt(Produkt produkt)
        {
            Produkter.Add(produkt);
        }

        public void FjernProdukt(Produkt produkt)
        {
            Produkter.Remove(produkt);
        }

        public int AntalProdukter()
        {
            return Produkter.Count;
        }

        public List<Produkt> GetProdukter()
        {
            return Produkter;
        }

        public decimal TotalPris()
        {
            decimal total = 0;
            foreach (Produkt produkt in Produkter)
            {
                total += produkt.Pris;
            }
            return total;
        }
    }


}
