using System;
namespace OOP_EmreElagoz.Models
{
    class Vliegtuigvakantie : Reis
    {
        private double VliegtuigTicket { get; set; }
        public Vliegtuigvakantie(double vliegtuigTicket, DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {
            VliegtuigTicket = vliegtuigTicket;
        }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs() + VliegtuigTicket;
        }
    }
}
