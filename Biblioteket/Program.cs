namespace Biblioteket
{
    class Program
    {
        public static void Main()
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek");
            Console.WriteLine(bibliotek.HentBibliotek());

            bibliotek.OpretLaaner(1, "Egon");
            bibliotek.OpretLaaner(2, "Hans");
            bibliotek.OpretLaaner(3, "Jens");

            Console.WriteLine(bibliotek.HentLaaner(0));
        }
    }
}