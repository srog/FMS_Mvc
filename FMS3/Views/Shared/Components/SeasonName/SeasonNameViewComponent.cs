using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Shared.ViewComponents.DivisionName
{
    public class SeasonNameViewComponent : ViewComponent
    {
        private ISeasonService _seasonService { get; }
        
        public SeasonNameViewComponent(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int seasonId)
        {
            return View("SeasonName", _seasonService.GetSeasonYear(seasonId));
        }
    }
}
