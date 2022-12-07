namespace Biblioteket
{
    class Program
    {
        public static void Main()
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek");
            Console.WriteLine(bibliotek.HentBibliotek());

            bibliotek.OpretLaaner(1, "Egon");

            Console.WriteLine(bibliotek.HentLaaner(0));
        }
    }
}