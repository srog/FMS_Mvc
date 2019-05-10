﻿using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();

        public IActionResult Start()
        {
            var game = _gameDetailsData.GetById(GlobalData.GameDetailsId);

            return View("Index", game);
        }
               
        public IActionResult LoadGame(int id)
        {
            var game = _gameDetailsData.GetById(id);
            GlobalData.GameDetailsId = id;
            GlobalData.CurrentSeasonId = game.CurrentSeasonId;
            return View("Index", game);
        }

        public IActionResult Index()
        {
            if (GlobalData.GameDetailsId == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            // TODO - cache this 
            var game = _gameDetailsData.GetById(GlobalData.GameDetailsId);
            return View(game);
        }

        public IActionResult BeginSeason()
        {
            var game = _gameDetailsData.AdvanceWeek();
            return View("Index", game);
        }

        public IActionResult AdvanceWeek()
        {
            var game = _gameDetailsData.AdvanceWeek();
            return View("Index",game);
        }

        public IActionResult CompleteSeason()
        {
            var seasonData = new SeasonData();
            var newYear = seasonData.CompleteCurrentSeason();

            var newSeason = new Season {Completed = false, GameDetailsId = GlobalData.GameDetailsId, StartYear = newYear };
            var newSeasonId = seasonData.AddSeason(newSeason);

            var teamSeasonData = new TeamSeasonData();
            teamSeasonData.PromotionAndRelegation(GlobalData.GameDetailsId, GlobalData.CurrentSeasonId, newSeasonId);

            var game = _gameDetailsData.SetGameToNewSeason(newSeasonId);

            // set globals to new data
            GlobalData.CurrentSeasonId = newSeasonId;

            return View("Index", game);
        }
    }
}
