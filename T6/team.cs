using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Team
    {
        //information
        public string Nimi { get; set; }
        public string Laji { get; set; }
        public string Sarja { get; set; }
        public int Mestaruudet { get; set; }
        public int Perustusvuosi { get; set; }

        //methods
        public void PrintData()
        {
            Console.WriteLine("Team information: ");
            Console.WriteLine("Joukkueen nimi : {0}", Nimi);
            Console.WriteLine("Laji : {0}", Laji);
            Console.WriteLine("Sarja : {0}", Sarja);
            Console.WriteLine("Mestaruudet : {0}", Mestaruudet);
            Console.WriteLine("Perustusvuosi : {0}", Perustusvuosi);

        }
        public override string ToString()
        {
            return "Nimi : " + Nimi + " Laji : " + Laji + " Sarja : " + Sarja + " Mestaruudet : "
                + Mestaruudet + " Perustuvuosi : " + Perustusvuosi ;

        }


    }
}
