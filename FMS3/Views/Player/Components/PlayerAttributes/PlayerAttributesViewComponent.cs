using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Player.Components.PlayerAttributes
{
    public class PlayerAttributesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var playerData = new PlayerAttributesData();
            var attributes = playerData.GetPlayerAttributes(playerId);

            return View("PlayerAttributes", attributes);
        }
    }
}
