using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.DivisionName
{
    public class SeasonNameViewComponent : ViewComponent
    {
        private ISeasonData _seasonData { get; }
        
        public SeasonNameViewComponent(ISeasonData seasonData)
        {
            _seasonData = seasonData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int seasonId)
        {
            return View("SeasonName", _seasonData.GetSeasonYear(seasonId));
        }
    }
}
