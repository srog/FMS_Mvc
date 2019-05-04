using FMS3.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.PlayerPosition
{
    public class PlayerPositionViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int positionId)
        {
            return View("PlayerPosition", Enum.GetName(typeof(PositionEnum), positionId));
        }
    }
}
