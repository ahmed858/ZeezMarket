using Microsoft.AspNetCore.Mvc;

namespace ZeezMarket.Api.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
