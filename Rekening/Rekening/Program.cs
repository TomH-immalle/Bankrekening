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

        static void Main(string[] args) {

            rekeningen.Add(b1);
            rekeningen.Add(b2);
            bool menu = false;

            while (!menu)
            {
            Console.WriteLine("1. Geld storten op de bankrekening.");
            Console.WriteLine("2. Geld afhalen van de bankrekening.");
            Console.WriteLine("3. Saldo bekijken.");
            Console.WriteLine("4. Maak een rekening aan.");
            Console.WriteLine("5. Exit.");
            int keuze = Convert.ToInt16(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        
                        Console.WriteLine("Op welke naam staat de rekening?");
                        string houder = Console.ReadLine();
                        var id = account(houder);
                        if (id == null)
                        {
                            Console.WriteLine("Deze bankrekening bestaat niet.");
                            break;
                        }
                        Console.WriteLine("Hoeveel geld wilt u storten?");
                        int hoeveel = Convert.ToInt32(Console.ReadLine());
                        id.saldo += hoeveel;                
                        break;
                    case 2:
                        Console.WriteLine("Op welke naam staat de rekening?");
                        string houder2 = Console.ReadLine();
                        var id2 = account(houder2);
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
                        Console.WriteLine("Op welke naam staat de rekening?");
                        string houder3 = Console.ReadLine();
                        var id3 = account(houder3);
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
                        Environment.Exit(0);
                        break;
                }
                
            }
        }



    }
}
