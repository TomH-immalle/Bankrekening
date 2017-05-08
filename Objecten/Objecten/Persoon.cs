using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objecten
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public int Leeftijd { get; set; }


        public Persoon(string Voornaam , int Leeftijd)
        {
            this.Voornaam = Voornaam;
            this.Leeftijd = Leeftijd;
        }
    }
    
}
