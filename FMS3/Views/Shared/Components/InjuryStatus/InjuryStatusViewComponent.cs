using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.InjuryStatus
{
    public class InjuryStatusViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int injuredWeeks)
        {
            var injuryStatus = injuredWeeks == 0 ? "No Injury" : ("Out for " + injuredWeeks + " weeks");
            return View("InjuryStatus", injuryStatus);
        }
    }
}
