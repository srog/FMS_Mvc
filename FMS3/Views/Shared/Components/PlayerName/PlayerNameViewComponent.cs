using System.Threading.Tasks;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Views.Shared.Components.PlayerName
{
    public class PlayerNameViewComponent : ViewComponent
    {
        private IPlayerData _playerData { get; }
        public PlayerNameViewComponent(IPlayerData playerData)
        {
            _playerData = playerData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId, bool shortName = false)
        {
            var player = new Models.Player
                {
                    Id = playerId,
                    Name = shortName ? _playerData.GetPlayerShortName(playerId) : _playerData.GetPlayerFullName(playerId)
                };

            return View("PlayerName", player);
        }
    }
}
