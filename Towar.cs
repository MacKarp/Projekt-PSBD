using System;
using System.Collections.Generic;

namespace Projekt_PSBD
{
    public class Towar
    {
        public int TowarID { get; set; }
        public string NazwaTowaru { get; set; }
        public virtual Producent Producent { get; set; }
        public double CenaTowaru { get; set; }

        public int IloscTowaru { get; set; }
        public Kraj KrajProdukcji { get; set; }
        public Magazyn Magazyn { get; set; }
    }
}