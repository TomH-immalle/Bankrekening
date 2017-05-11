using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    class Program
    {
        static void Main(string[] args)
        {

            Bankrekening b1 = new Bankrekening();
            
            bool menu = false;

            while (!menu)
            {

            Console.WriteLine("1. Geld storten op de bankrekening.");
            Console.WriteLine("2. Geld afhalen van de bankrekening.");
            Console.WriteLine("3. Saldo bekijken.");
            Console.WriteLine("4. Exit.");
            int keuze = Convert.ToInt16(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Hoeveel geld wilt u storten?");
                        int hoeveel = Convert.ToInt32(Console.ReadLine());
                        b1.saldo += hoeveel;                
                        break;
                    case 2:
                        Console.WriteLine("Hoeveel geld wilt u afhalen?");
                        int hoeveel2 = Convert.ToInt32(Console.ReadLine());
                        if (hoeveel2 > b1.saldo)
                        {
                            Console.WriteLine("Saldo ontoereikbaar.");
                        }
                        else
                        {
                            b1.saldo -= hoeveel2;  
                        }
                                    
                        break;
                    case 3:
                        Console.WriteLine("Uw saldo bedraagt " + Convert.ToString(b1.saldo));
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                
            }
        }



    }
}
