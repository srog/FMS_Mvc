using FMS3.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.DivisionName
{
    public class DivisionNameViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int divisionId)
        {
            var divisionName = Enum.GetName(typeof(DivisionEnum), divisionId);

            var division = new KeyValuePair<int, string>
            (Enum.Parse(typeof(DivisionEnum), divisionName).GetHashCode(),divisionName);

            return View("DivisionName", division);
        }
    }
}
