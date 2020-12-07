namespace OOP_EmreElagoz.Models
{
    public class LogMessage
    {
        public string Boodschap { get; set; }
        public int ID { get; set; }
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = CreateID();
        }
        public int CreateID()
        {
            return LoggerService.Logs.Length;
        }
    }
}
