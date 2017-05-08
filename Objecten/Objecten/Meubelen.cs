using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objecten
{
    class Meubel
    {
        public string Artikelnaam { get; set; }
        public int Eenheidsprijs { get; set; }
        public int Aantal { get; set; }

        public Meubel(string Artikelnaam, int Eenheidsprijs, int Aantal)
        {
            this.Artikelnaam = Artikelnaam;
            this.Eenheidsprijs = Eenheidsprijs;
            this.Aantal = Aantal;
        }
    }
}
