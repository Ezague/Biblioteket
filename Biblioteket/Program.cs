namespace Biblioteket
{
    class Program
    {
        public static void Main()
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek");
            bool afslut = false;

            while (!afslut)
            {
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.WriteLine("Du kan vælge følgende:");
                Console.WriteLine("v: Vis biblioteket navn og dato");
                Console.WriteLine("o: Opret låner");
                Console.WriteLine("u: Udskrive lånere");
                Console.WriteLine("x: Afslut");
                Console.WriteLine("-------------------");

                ConsoleKeyInfo valg = Console.ReadKey(true);
                switch (valg.Key)
                {
                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine(bibliotek.HentBibliotek());
                        Thread.Sleep(5000);
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine("Indtast låner nummer:");
                        int ID;
                        if (!int.TryParse(Console.ReadLine(), out ID))
                        {
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.WriteLine("Indtast låner navn:");
                            string? laanerNavn = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(laanerNavn))
                            {
                                Console.Clear();
                                Console.WriteLine("Du skal indtaste et navn");
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.WriteLine(bibliotek.OpretLaaner(ID, laanerNavn));
                                Console.WriteLine("Låner oprettet");
                            }
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Clear();
                        if (bibliotek.HentAlleLaanere() == "")
                        {
                            Console.WriteLine("Der er ingen lånere");
                            Thread.Sleep(3000);
                            break;
                        }
                        Console.WriteLine(bibliotek.HentAlleLaanere());
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.X:
                        afslut = true;
                        Console.Clear();
                        Console.WriteLine("Programmet afsluttes");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}