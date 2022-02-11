using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ucet> seznamUctu = new List<Ucet>();

            try
            {
                String cislo;
                String majitel;
                double zustatek;

                Console.WriteLine("Zadejte cislo uctu: ");
                cislo = Console.ReadLine();
                Console.WriteLine("Zadejte jmeno: ");
                majitel = Console.ReadLine();
                Console.WriteLine("Zadejte zustatek: ");
                zustatek = Double.Parse(Console.ReadLine());

                seznamUctu.Add(new Ucet(cislo, majitel, zustatek));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            seznamUctu.Add(new DebetniUcet("12331122", "Petr", 1000, 1000));
            seznamUctu.Add(new SporiciUcet("64564654", "Marek", 5000, 2.2));

            foreach (Ucet ucet in seznamUctu)
            {
                Console.WriteLine(ucet.toString());
                Console.WriteLine(ucet.Vlozit(100));
                Console.WriteLine(ucet.Vybrat(200));
                if (ucet.GetType() == typeof(SporiciUcet)){
                    Console.WriteLine(((SporiciUcet)ucet).PripsatUrok());
                }
                Console.WriteLine(ucet.toString());
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
