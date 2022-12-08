using System;

namespace Biblioteket
{
    public class Bibliotek
    {
        List<Laaner> laanere = new List<Laaner>();
        public string biblioteksNavn { get; init; }
        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }
        public string HentBibliotek()
        {
            return "Velkommen til " + biblioteksNavn + "- datoen idag er: " + DateTime.Now.ToShortDateString();
        }

        public string OpretLaaner(int laanerNummer, string navn)
        {
            Laaner laaner = new Laaner(laanerNummer, navn);
            laanere.Add(laaner);
            return $"Lånernummer: {laanerNummer} - Navn: {navn} er oprettet hos {biblioteksNavn}\n";
        }

        public string HentLaaner(int id)
        {
            return $"Lånernummer: {laanere[id].laanerNummer} - Navn: {laanere[id].navn} er låner hos {biblioteksNavn}\n";
        }

        public string HentAlleLaanere()
        {
            string laanereString = "";
            foreach (Laaner laaner in laanere)
            {
                laanereString += $"Lånernummer: {laaner.laanerNummer} - Navn: {laaner.navn} er låner hos {biblioteksNavn}";
            }
            return laanereString;
        }

    }
}