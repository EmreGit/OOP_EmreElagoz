using OOP_EmreElagoz.Interface;
namespace OOP_EmreElagoz.Models
{
    public class ReisReservatie : Iloggable
    {
        public LogMessage LogMessage { get; set; }
        public Persoon Persoon { get; set; }
        public Reisbureau Reisbureau { get; set; }
        public Reis Reis { get; set; }
        public ReisReservatie(Persoon persoon, Reis reis, Reisbureau reisbureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
            LogMessage = new LogMessage($"Deze werd gereserveerd door {persoon.Naam} bij reiskantoor {reisbureau.Naam}");
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}