using System;
namespace OOP_EmreElagoz.Models
{
    class AutoVakantie : Reis
    {
        private const double EXTRAPRIJSHUURAUTO = 10;
        public bool EigenWagen { get; set; }
        public AutoVakantie(bool eigenWagen, DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {
            EigenWagen = eigenWagen;
        }
        public override double BerekenPrijs()
        {
            {
                if (EigenWagen)
                {
                    return base.BerekenPrijs();
                }
                else
                {
                    return base.BerekenPrijs() + AantalDagen * EXTRAPRIJSHUURAUTO * (int)(AantalPersonen / 5);
                }
            }
        }
    }
}