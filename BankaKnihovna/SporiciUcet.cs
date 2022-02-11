using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKnihovna
{
    public class SporiciUcet : Ucet
    {
        private double urokovaSazba;

        public SporiciUcet(string cislo, string majitel, double zustatek, double urokovaSazba) : base(cislo, majitel, zustatek)
        {
            this.urokovaSazba = urokovaSazba;
        }

        public SporiciUcet(string cislo, string majitel, double urokovaSazba) : base(cislo, majitel)
        {
            
            this.urokovaSazba = urokovaSazba;
        }

        public string PripsatUrok()
        {
            zustatek = zustatek * (1 + urokovaSazba / 100);
            return "Urok byl pripsan na ucet. Novy zustatek: " + zustatek + " Kc.";
        }

        public override string ToString()
        {
            return "Sporici ucet [" + VratCisloUctuCele() + ", majitel: " + majitel + ". zůstatek: " + zustatek + " Kc, urokova sazba: " + urokovaSazba + " %]";
        }
    }
}
