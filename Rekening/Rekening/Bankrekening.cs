using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    class Bankrekening
    {
        public string naam { get; set; }
        public int saldo { get; set; }

        public Bankrekening(string naam, int saldo)
        {
            this.naam = naam;
            this.saldo = saldo;
        }

         
    }
}
