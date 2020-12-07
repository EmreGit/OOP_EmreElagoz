using System;
namespace OOP_EmreElagoz.Models
{
    public abstract class Reis
    {
        private const double BASISDAGPRIJS = 40;

        public int AantalPersonen { get; set; }
        public int AantalDagen { get; set; }
        public DateTime VertrekDatum { get; set; }
        public DateTime TerugkeerDatum { get; set; }
        public Reis(DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            if (vertrekDatum.Date < DateTime.Today)
            {
                Console.WriteLine("De vertrekdatum kan niet in het verleden zijn");
            }
            else
            {
                VertrekDatum = vertrekDatum;
            }
            if (terugkeerDatum.Date < DateTime.Today)
            {
                Console.WriteLine("De vertrekdatum moet vóór de terugkeerdatum zijn");
            }
            else
            {
                TerugkeerDatum = terugkeerDatum;
            }
            if (vertrekDatum.Date > terugkeerDatum.Date)
            {
                Console.WriteLine("De vertrekdatum moet vóór de terugkeerdatum zijn");
            }
            AantalDagen = (int)(terugkeerDatum - vertrekDatum).TotalDays;
        }
        public virtual double BerekenPrijs()
        {

            return BASISDAGPRIJS * AantalDagen * AantalPersonen;
        }
    }
}