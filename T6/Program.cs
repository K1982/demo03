using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team();
            team1.Nimi = "Siipe";
            team1.Laji = "Pesis";
            team1.Sarja = "Ykköspesis";
            team1.Mestaruudet = 0;
            team1.Perustusvuosi = 1987;
            team1.PrintData();
            Console.WriteLine(team1.ToString());

            Team team2 = new Team();
            team2.Nimi = "Kalpa";
            team2.Laji = "Jääkiekko";
            team2.Sarja = "Liiga";
            team2.Mestaruudet = 0;
            team2.Perustusvuosi = 1929;
            team2.PrintData();
            Console.WriteLine(team2.ToString());

            Team team3 = new Team();
            team3.Nimi = "SSV";
            team3.Laji = "Salibandy";
            team3.Sarja = "Salibandyliiga";
            team3.Mestaruudet = 11;
            team3.Perustusvuosi = 1986;
            team3.PrintData();
            Console.WriteLine(team3.ToString());

            Team team4 = new Team();
            team4.Nimi = "Bisons";
            team4.Laji = "Koripallo";
            team4.Sarja = "Korisliiga";
            team4.Mestaruudet = 2;
            team4.Perustusvuosi = 1964;
            team4.PrintData();
            Console.WriteLine(team4.ToString());

            Team team5 = new Team();
            team5.Nimi = "Sampo";
            team5.Laji = "Lentopallo";
            team5.Sarja = "SM-liiga";
            team5.Mestaruudet = 3;
            team5.Perustusvuosi = 1924;
            team5.PrintData();
            Console.WriteLine(team5.ToString());


            Console.ReadLine();
        }
    }
}
