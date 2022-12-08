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

        public string OpretLaaner(int laanerNummer, string navn, string email)
        {
            Laaner laaner = new Laaner(laanerNummer, navn, email);
            laanere.Add(laaner);
            return $"Lånernummer: {laanerNummer} - Navn: {navn} - Email: {email} er oprettet hos {biblioteksNavn}\n";
        }

        public string HentAlleLaanere()
        {
            string laanereString = "";
            foreach (Laaner laaner in laanere)
            {
                laanereString += $"Lånernummer: {laaner.laanerNummer} - Navn: {laaner.navn} er låner hos {biblioteksNavn}\n";
            }
            return laanereString;
        }

        public string HentLaaner(int laanerNummer)
        {
            foreach (Laaner laaner in laanere)
            {
                if (laaner.laanerNummer == laanerNummer)
                {
                    return $"Lånernummer: {laaner.laanerNummer} - Navn: {laaner.navn} - Email: {laaner.email} er låner hos {biblioteksNavn}\n";
                }
            }
            return $"Lånernummer: {laanerNummer} findes ikke hos {biblioteksNavn}\n";
        }

    }
}