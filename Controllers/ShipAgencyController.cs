using Microsoft.AspNetCore.Mvc;
using ShipServicesApp.Services;

namespace ShipServicesApp.Controllers
{
    public class ShipAgencyController : Controller
    {
        private readonly DemoDataService _data;
        public ShipAgencyController(DemoDataService data) => _data = data;

        public IActionResult Index() => View(_data.ShipAgencies);
    }
}