namespace Biblioteket
{
    public class Laaner : Person // Laaner klassen arver fra Person klassen
    {
        public int laanerNummer { get; }

        public Laaner(int laanerNummer, string navn, string email) : base(navn, email) //Tilføjer laanerNummer til Laaner
        {
            this.laanerNummer = laanerNummer;
        }

    }
}