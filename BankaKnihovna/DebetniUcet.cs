using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKnihovna
{
    public class DebetniUcet : Ucet
    {
        private double debet;

        public DebetniUcet(string cislo, string majitel, double zustatek, double debet) : base(cislo, majitel, zustatek)
        {
            this.debet = debet;
        }

        public DebetniUcet(string cislo, string majitel, double debet):base(cislo, majitel)
        {
            this.debet = debet;
        }

        public string VybratCastka(double castka)
        {
            if (castka <= zustatek + debet)
            {
                zustatek -= castka;
                return "Finance uspesne vybrany. Novy zustatek: " + zustatek + "Kc.";
            }
            else
            {
                return "Vybirana castka je moc velka.";
            }
        }

        public override string ToString()
        {
            return "Debetni ucet [" + VratCisloUctuCele() + ", majitel: " + majitel + ". zůstatek: " + zustatek + " Kc, debet: " + debet + " Kc]";
        }
    }
}
