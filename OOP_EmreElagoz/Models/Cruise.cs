using System;
namespace OOP_EmreElagoz.Models
{
    class Cruise : Reis
    {
        private const double CRUISEPRIJSEXTRADAGKOST = 10;
        private const double VIPCOST = 1.5;
        public bool VIP { get; set; }
        public Cruise(DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum) { }
        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return (base.BerekenPrijs() + AantalDagen * CRUISEPRIJSEXTRADAGKOST * AantalPersonen) * VIPCOST;
            }
            else
            {
                return base.BerekenPrijs() + AantalDagen * CRUISEPRIJSEXTRADAGKOST * AantalPersonen;
            }
        }
    }
}
