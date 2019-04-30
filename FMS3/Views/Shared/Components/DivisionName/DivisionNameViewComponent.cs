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
            return View("Default", Enum.GetName(typeof(DivisionEnum), divisionId));
        }
    }
}
