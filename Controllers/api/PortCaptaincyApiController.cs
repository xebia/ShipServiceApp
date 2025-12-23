using Microsoft.AspNetCore.Mvc;
using ShipServicesApp.Services;
using ShipServicesApp.Models;

namespace ShipServicesApp.Controllers.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortCaptaincyApiController : ControllerBase
    {
        private readonly DemoDataService _data;
        public PortCaptaincyApiController(DemoDataService data) => _data = data;

        [HttpGet]
        public IActionResult GetAll() => Ok(_data.PortCaptains);
    }
}
