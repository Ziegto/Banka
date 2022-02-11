using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaConsole
{
    internal class Ucet
    {
        private const int KODBANKY = 1234;

        protected string cislo;
        protected string majitel;
        protected double zustatek;

        public Ucet(string cislo, string majitel, double zustatek)
        {
            this.cislo = cislo;
            this.majitel = majitel;
            this.zustatek = zustatek;
        }

        public Ucet(string cislo, string majitel)
        {
            this.cislo = cislo;
            this.majitel = majitel;
        }

        public string Vlozit(double castka)
        {
            zustatek += castka;
            return "Vklad byl uspesne proveden. Novy zustatek: " + zustatek + "Kc.";
        }

        public string Vybrat(double castka)
        {
            if (castka > zustatek)
            {
                return "Nedostatek financi na ucte.";
            }
            else
            {
                zustatek -= castka;
                return "Finance uspesne vybrany. Novy zustatek: " + zustatek + "Kc.";
            }
        }

        protected string VratCisloUctuCele() { return cislo + "/" + KODBANKY; }

        public string toString()
        {
            return "Ucet [" + VratCisloUctuCele() + ", majitel: " + majitel + ". zůstatek: " + zustatek + " Kc]";
        }
    }
}
