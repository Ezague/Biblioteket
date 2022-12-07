using System;

namespace Biblioteket
{
    public class Laaner
    {
        public int laanerNummer { get; }
        public string navn { get; }

        public Laaner(int laanerNummer, string navn)
        {
            this.laanerNummer = laanerNummer;
            this.navn = navn;
        }

    }
}