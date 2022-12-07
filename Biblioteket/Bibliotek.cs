using System;

namespace Biblioteket
{
    class Bibliotek
    {
        public string biblioteksNavn { get; init; }
        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }
        public string HentBibliotek()
        {
            return "Velkommen til " + biblioteksNavn + "- datoen idag er: " + DateTime.Now.ToShortDateString();
        }
    }
}