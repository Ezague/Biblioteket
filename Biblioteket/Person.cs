namespace Biblioteket
{
    public class Person
    {
        public string navn { get; }
        public string email { get; }

        public Person(string navn, string email)
        {
            this.navn = navn;
            this.email = email;
        }
    }
}
