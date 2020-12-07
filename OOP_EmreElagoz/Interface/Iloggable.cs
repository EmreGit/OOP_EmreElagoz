using OOP_EmreElagoz.Models;
namespace OOP_EmreElagoz.Interface
{
    interface Iloggable //To avoid a warning, you have to use an uppercase and so I did
    {
        LogMessage LogMessage { get; }
    }
}
