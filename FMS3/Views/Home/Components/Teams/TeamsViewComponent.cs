using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.ViewComponents
{
    public class TeamsViewComponent : ViewComponent
    {
        private static FmsService.FmsServiceClient _fmsServiceClient = new FmsService.FmsServiceClient();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teams = await _fmsServiceClient.GetAllTeamsAsync();
            return View(teams);
        }

    }
}
