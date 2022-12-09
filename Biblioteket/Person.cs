namespace Biblioteket
{
    public class Person // Person klassen
    {
        public string navn { get; }
        public string email { get; }

        public Person(string navn, string email) // Tilføjer navn og email til Person
        {
            this.navn = navn;
            this.email = email;
        }
    }
}
