using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.DivisionName
{
    public class SeasonNameViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int seasonId)
        {
            var seasondata = new SeasonData();
            var season = seasondata.GetSeason(seasonId);

            return View("SeasonName", season.StartYear);
        }
    }
}
