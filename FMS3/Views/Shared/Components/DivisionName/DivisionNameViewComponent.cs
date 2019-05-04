using FMS3.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.DivisionName
{
    public class DivisionNameViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int divisionId)
        {
            var division = Enum.GetName(typeof(DivisionEnum), divisionId);
            return View("DivisionName", division);
        }
    }
}
