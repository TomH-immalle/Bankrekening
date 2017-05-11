using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    class Program
    {
           static List<Bankrekening> rekeningen = new List<Bankrekening>();
           static Bankrekening b1 = new Bankrekening("tom", 500);
           static Bankrekening b2 = new Bankrekening("wout", 2000);

        static public Bankrekening account(string naam)
        {
            foreach ( Bankrekening rekening in rekeningen)
            {
                if (rekening.naam == naam)
                {
                    return rekening;
                }
            }

            return null;
        }

        static public Bankrekening vraagAcc()
        {
            Console.WriteLine("Op welke naam staat de rekening?");
            string houder = Console.ReadLine();
            var id = account(houder);
            return id;
        }

        static void Main(string[] args) {

            rekeningen.Add(b1);
            rekeningen.Add(b2);
            
            bool menu = false;

            while (!menu)
            {
                Console.WriteLine("___________________________________");
            Console.WriteLine("1. Geld storten op de bankrekening.");
            Console.WriteLine("2. Geld afhalen van de bankrekening.");
            Console.WriteLine("3. Saldo bekijken.");
            Console.WriteLine("4. Maak een rekening aan.");
            Console.WriteLine("5. Rekening sluiten.");
            Console.WriteLine("6. Exit.");
            string strkeuze = Console.ReadLine();
                if (!strkeuze.All(char.IsDigit) || strkeuze.Length == 0)
                {
                    Console.WriteLine("Dit is geen optie.");
                    continue;
                }
                
            int keuze = Convert.ToInt32(strkeuze);

                switch (keuze)
                {
                    case 1:

                        var id = vraagAcc();
                        if ( id == null)
                        {
                            Console.WriteLine("Deze bankrekening bestaat niet.");
                            break;
                        }
                        Console.WriteLine("Hoeveel geld wilt u storten?");
                        int hoeveel = Convert.ToInt32(Console.ReadLine());
                        id.saldo += hoeveel;                
                        break;

                    case 2:

                        var id2 = vraagAcc();
                        if (id2 == null)
                        {
                            Console.WriteLine("Deze bankrekening bestaat niet.");
                            break;
                        }
                        Console.WriteLine("Hoeveel geld wilt u afhalen?");
                        int hoeveel2 = Convert.ToInt32(Console.ReadLine());
                        if (hoeveel2 > id2.saldo)
                        {
                            Console.WriteLine("Saldo ontoereikbaar.");
                        }
                        else
                        {
                            id2.saldo -= hoeveel2;  
                        }
                                    
                        break;

                    case 3:

                        var id3 = vraagAcc();
                        if (id3 == null)
                        {
                            Console.WriteLine("Deze rekening bestaat niet.");
                            break;
                        }
                        Console.WriteLine("Uw saldo bedraagt " + Convert.ToString(id3.saldo));
                        break;

                    case 4:
                        Console.WriteLine("Geef uw naam.");
                        string naam = Console.ReadLine();
                        rekeningen.Add(new Bankrekening(naam , 0));
                        break;

                    case 5:
                        Console.WriteLine("Geef uw naam.");
                        string eigenaar = Console.ReadLine();
                        var id4 = account(eigenaar);
                        if (id4 == null)
                        {
                            Console.WriteLine("Deze bankrekening bestaat niet.");
                            
                        }
                        else
                        {
                            rekeningen.Remove(id4);
                            Console.WriteLine("De rekening is gesloten.");
                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Dit is geen optie.");
                        break;
                }
                
            }
        }



    }
}
