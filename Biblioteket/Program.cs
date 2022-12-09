using System;
using System.Text.RegularExpressions;

namespace Biblioteket
{
    class Program
    {
        public static void Main()
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek"); // Opretter bibliotek med navn
            bool afslut = false; //Sætter afslut til false (programmet kører)

            while (!afslut)
            {
                // Udskriver vores menu i konsollen
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.WriteLine("Du kan vælge følgende:");
                Console.WriteLine("v: Vis biblioteket navn og dato");
                Console.WriteLine("o: Opret låner");
                Console.WriteLine("u: Udskriv alle lånere");
                Console.WriteLine("f: Udskriv specifik låner");
                Console.WriteLine("x: Afslut");
                Console.WriteLine("-------------------");

                ConsoleKeyInfo valg = Console.ReadKey(true); // Venter på at brugeren trykker på en tast
                switch (valg.Key) // Switch case der tjekker hvilken tast der er trykket på
                {
                    case ConsoleKey.V: // Hvis knappen er V så kører vi følgende kode
                        Console.Clear();
                        Console.WriteLine(bibliotek.HentBibliotek()); // Udskriver bibliotekets navn og dato ud fra HentBibliotek metoden i Bibliotek.cs
                        Thread.Sleep(5000);
                        break;
                    case ConsoleKey.O: // Hvis knappen er O så kører vi følgende kode
                        Console.WriteLine("Indtast låner nummer:");
                        int ID;
                        if (!int.TryParse(Console.ReadLine(), out ID) || ID <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et gyldigt nummerisk tal");
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
                                Console.WriteLine("Indtast låner email:");
                                string? laanerEmail = Console.ReadLine();
                                Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); // Regex til at tjekke om emailen er gyldig
                                Match match = rx.Match(laanerEmail); // Tjekker om emailen er gyldig
                                if (match.Success) // Hvis emailen er gyldig så kører vi følgende kode
                                {
                                    Console.Clear();
                                    Console.WriteLine(bibliotek.OpretLaaner(ID, laanerNavn, laanerEmail)); // Opretter en laaner ud fra OpretLaaner metoden i Bibliotek.cs
                                    Console.WriteLine("Låner oprettet"); // Udskriver at låneren er oprettet
                                }
                                else // Hvis emailen ikke er gyldig så kører vi følgende kode
                                {
                                    Console.Clear();
                                    Console.WriteLine("Du skal indtaste en email");
                                    Thread.Sleep(3000);
                                }
                            }
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case ConsoleKey.U: // Hvis knappen er U så kører vi følgende kode
                        Console.Clear();
                        if (bibliotek.HentAlleLaanere() == "") // Tjekker om der er nogen lånere
                        {
                            Console.WriteLine("Der er ingen lånere"); // Hvis der ingen lånere er så udskriver vi at der ingen lånere er
                            Thread.Sleep(3000);
                            break;
                        }
                        Console.WriteLine(bibliotek.HentAlleLaanere()); // Ellers udskriver vi alle lånere
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.F: // Hvis knappen er F så kører vi følgende kode
                        Console.WriteLine("Indtast låner nummer:");
                        int laanerID;
                        if (!int.TryParse(Console.ReadLine(), out laanerID))
                        {
                            Console.Clear();
                            Console.WriteLine("Du skal indtaste et tal");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(bibliotek.HentLaaner(laanerID)); // Udskriver låneren ud fra HentLaaner metoden i Bibliotek.cs
                            Thread.Sleep(3000);
                        }
                        break;
                    case ConsoleKey.X: // Hvis knappen er X så kører vi følgende kode
                        afslut = true;
                        Console.Clear();
                        Console.WriteLine("Programmet afsluttes");
                        break;
                    default: // Hvis der trykkes på en anden tast så kører vi følgende kode
                        Console.WriteLine("Ugyldigt valg");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}