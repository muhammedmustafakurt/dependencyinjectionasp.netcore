using TransportService.Interfaces;

namespace TransportService.Services
{
    public class BusService : IBusService
    {
        public string GetBus(string passengerName)
        {
            return $"{passengerName} için otobüs bileti alındı.";
        }
    }
}