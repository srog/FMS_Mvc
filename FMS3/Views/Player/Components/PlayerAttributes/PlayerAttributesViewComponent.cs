using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Player.Components.PlayerAttributes
{
    public class PlayerAttributesViewComponent : ViewComponent
    {
        private IPlayerAttributeService _playerAttributesService { get; }
        public PlayerAttributesViewComponent(IPlayerAttributeService playerAttributeService)
        {
            _playerAttributesService = playerAttributeService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var attributes = _playerAttributesService.GetByPlayer(playerId).ToList();

            return View("PlayerAttributes", attributes);
        }
    }
}
