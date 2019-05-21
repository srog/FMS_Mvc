using System.Threading.Tasks;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Views.Shared.Components.PlayerName
{
    public class PlayerNameViewComponent : ViewComponent
    {
        private IPlayerService _playerService { get; }
        public PlayerNameViewComponent(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId, bool shortName = false)
        {
            var player = new Models.Player
                {
                    Id = playerId,
                    Name = shortName ? _playerService.GetPlayerShortName(playerId) : _playerService.GetPlayerName(playerId)
                };

            return View("PlayerName", player);
        }
    }
}
