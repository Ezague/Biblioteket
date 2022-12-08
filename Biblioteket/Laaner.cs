namespace Biblioteket
{
    public class Laaner : Person
    {
        public int laanerNummer { get; }

        public Laaner(int laanerNummer, string navn, string email) : base(navn, email)
        {
            this.laanerNummer = laanerNummer;
        }

    }
}