using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private static FmsService.FmsServiceClient _fmsServiceClient = new FmsService.FmsServiceClient();

        public IActionResult Index()
        {
            var playerList = _fmsServiceClient.GetAllPlayersAsync().Result;

            return View(playerList);
        }
    }
}
