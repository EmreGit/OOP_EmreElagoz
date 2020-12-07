using System;
using OOP_EmreElagoz.Models;

namespace OOP_EmreElagoz
{
    class Program
    {
        static void Main()
        {
            Reis[] reizen = ShowReizen();
            Persoon[] personen = ShowPersonen();
            Reisbureau[] bureaus = ShowBureaus();
            ReisReservatie[] reservaties = ShowReservaties(reizen, personen, bureaus);
            foreach (ReisReservatie reservatie in reservaties)
            {
                Console.WriteLine("\n");
                Console.WriteLine(
                $"De reis gaat u {reservatie.Reis.BerekenPrijs()} euro kosten\n" +
                $"De reis gaat {reservatie.Reis.AantalDagen} dagen in beslag nemen" +
                $"\n" +
                $"Deze reis werd gereserveerd door {reservatie.Persoon.Naam}\n" +
                $"Deze reid werd gereserveerd bij reiskantoor {reservatie.Reisbureau.Naam}\n" +
                $"Gelegen te {reservatie.Reisbureau.Postcode} {reservatie.Reisbureau.Gemeente}\n" +
                $"{reservatie.Reisbureau.Straat}");
            }
            foreach (var item in LoggerService.Logs)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Log");
                Console.WriteLine("ID " + item.ID);
                Console.WriteLine(item.Boodschap);
            }
            Console.ReadLine();
        }
        private static Reisbureau[] ShowBureaus()
        {
            Reisbureau[] bureaus = new Reisbureau[] {
                new Reisbureau()
                {
                        Gemeente = "Halle",
                        Postcode = 1500,
                        Straat = "Sint-Rochusstraat 65",
                        Naam = "SelectAir"
                },
                new Reisbureau()
                {
                        Gemeente = "Halle",
                        Postcode = 1500,
                        Straat = "Basiliekstraat 72",
                        Naam = "TUI"
                },
                new Reisbureau()
                {
                        Gemeente = "Halle",
                        Postcode = 1500,
                        Straat = "Basiliekstraat 92",
                        Naam = "Neckermann"
                }
            };
            return bureaus;
        }
        private static Reis[] ShowReizen()
        {
            Reis[] reizen = new Reis[] {
                new Cruise(new DateTime(2021, 06, 15), new DateTime(2021, 06, 30))
            {
                AantalPersonen = 16,
                VIP = true
            },
             new AutoVakantie(false, new DateTime(2021, 03, 18), new DateTime(2021, 5, 18))
            {
                AantalPersonen = 7,
            },
            new Vliegtuigvakantie(400, new DateTime(2077, 12, 10), new DateTime(2078, 06, 15))
            {
                AantalPersonen = 3,
            }
        };
            return reizen;
        }
        private static ReisReservatie[] ShowReservaties(Reis[] reizen, Persoon[] personen, Reisbureau[] bureaus)
        {
            ReisReservatie[] reservaties = new ReisReservatie[3];
            for (int i = 0; i < reservaties.Length; i++)
            {
                reservaties[i] = new ReisReservatie(personen[i], reizen[i], bureaus[i]);
            }
            return reservaties;
        }
        private static Persoon[] ShowPersonen()
        {
            Persoon[] personen = new Persoon[] {
            new Persoon("Emre", "Elagöz")
            {

                Gemeente = "Halle",
                Postcode = 1500,
                Straat = "Postweg 11"

            },
            new Persoon("Thor", "Odinson")
            {
                Gemeente = "Valhalla",
                Postcode = 0001,
                Straat = "HeimdallStraat 1"
            },
            new Persoon("Brown", "Doctor")
            {
                Gemeente = "Hill Valley",
                Postcode = 1985,
                Straat = "Longfellow Ave 1640"
            }
            };
            return personen;
        }
    }
}
