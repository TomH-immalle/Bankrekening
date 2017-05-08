using Objecten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objecten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> personen = new List<Persoon>
            {
                new Persoon("Joske", 13),
                new Persoon("Jantje", 14),
                new Persoon("Mieke", 15)
            };

            for (int i = 0; i < personen.Count; i++)
            {

                Console.WriteLine(personen[i].Voornaam + " is " + personen[i].Leeftijd + " jaar oud.");
            }

            List<Meubel> meubels = new List<Meubel>
            {
                new Meubel("tafel", 399, 1),
                new Meubel("stoel", 79 , 4),
                new Meubel("bed", 122,5),
                new Meubel("matras", 99, 5)
            };
             meubels.Add(new Meubel("zetel", 200, 3)); // andere manier van item toevoegen aan een lijst.
            int totaal = 0;
            int rekening = 0;
            foreach (var meubel in meubels)
            {
                if (meubel.Aantal < 2)
                {
                     Console.WriteLine("Deze " + meubel.Artikelnaam + " kost "+ meubel.Eenheidsprijs + ".");
                }
                else
                {
                    
                    totaal = meubel.Aantal * meubel.Eenheidsprijs;
                    Console.WriteLine("Deze "+ meubel.Aantal +" artikelen (" + meubel.Artikelnaam + ") kost in het totaal " + totaal + " euro.");
                }
                rekening += meubel.Aantal * meubel.Eenheidsprijs;
            }
            Console.WriteLine("De totale rekening is " + rekening + " euro.");

        }
       
    }
}
