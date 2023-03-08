using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECs_WebShop
{
    public class Adresse
    {

        public int AdresseID { get; set; }

        public string Gadenavn { get; set; }

        public int Gadenummer { get; set; }

        public int Postnummer { get; set; }

        public string ByNavn { get; set; }





        public Adresse(string gadenavn, int gadenummer, int postnummer, string by)
        {
            Gadenavn = gadenavn;
            Gadenummer = gadenummer;
            Postnummer = postnummer;
            ByNavn = by;
        }

    }
}