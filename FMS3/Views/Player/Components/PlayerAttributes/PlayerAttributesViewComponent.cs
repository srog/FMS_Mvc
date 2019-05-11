using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Player.Components.PlayerAttributes
{
    public class PlayerAttributesViewComponent : ViewComponent
    {
        private IPlayerAttributesData _playerAttributesData { get; }
        public PlayerAttributesViewComponent(IPlayerAttributesData playerAttributesData)
        {
            _playerAttributesData = playerAttributesData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var attributes = _playerAttributesData.GetPlayerAttributes(playerId).ToList();

            return View("PlayerAttributes", attributes);
        }
    }
}
