using Microsoft.AspNetCore.Mvc;
using TransportService.Interfaces;

namespace TransportService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportController : Controller
    {
        private readonly ITaxiService _taxiService;
        private readonly IBusService _busService;

        public TransportController(ITaxiService taxiService, IBusService busService)
        {
            _taxiService = taxiService;
            _busService = busService;
        }

        [HttpGet("taxi/{passengerName}")]
        public IActionResult GetTaxi(string passengerName)
        {
            var message = _taxiService.GetRide(passengerName);
            return View("Taxi", message); 
        }

        [HttpGet("bus/{passengerName}")]
        public IActionResult GetBus(string passengerName)
        {
            var message = _busService.GetBus(passengerName);
            return View("Bus", message);
        }
    }
}
