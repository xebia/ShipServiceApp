using Microsoft.AspNetCore.Mvc;
using ShipServicesApp.Services;
using ShipServicesApp.Models;

namespace ShipServicesApp.Controllers.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipAgenciesApiController : ControllerBase
    {
        private readonly DemoDataService _data;
        public ShipAgenciesApiController(DemoDataService data) => _data = data;

        [HttpGet]
        public IActionResult GetAll() => Ok(_data.ShipAgencies);
    }
}