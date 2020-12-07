namespace OOP_EmreElagoz.Models
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Straat { get; set; }
        public Persoon(string voornaam, string familienaam)
        {
            Naam = $"{voornaam} {familienaam}";
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
    }
}