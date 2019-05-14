﻿using FMS3.Models;

namespace FMS3.Data.Interfaces
{
    public interface IPlayerData
    {
        PlayerListDisplay GetAllPlayers(int? teamId = null);
        Player GetPlayer(int id);
        int AddPlayer(Player player);
        int UpdatePlayer(Player player);
        int DeletePlayer(int id);
    }
}
