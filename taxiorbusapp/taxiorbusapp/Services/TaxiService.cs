using TransportService.Interfaces;

namespace TransportService.Services
{
    public class TaxiService : ITaxiService
    {
        public string GetRide(string passengerName)
        {
            return $"{passengerName} için taksi çağrıldı.";
        }
    }
}
