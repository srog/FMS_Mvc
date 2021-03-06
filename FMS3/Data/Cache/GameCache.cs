﻿using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Data.Cache
{
    public static class GameCache
    {
        public static bool StaticDataLoaded { get; set; }

        public static int NumberOfWeeksInSeason = 22;
        public static int NumberOfTeamsInDivision = 12;

        public static Dictionary<int, string> TeamNames = new Dictionary<int, string>();
        public static Dictionary<int, string> PlayerShortNames = new Dictionary<int, string>();
        public static Dictionary<int, string> PlayerFullNames = new Dictionary<int, string>();

        public static Dictionary<int, int> SeasonYear = new Dictionary<int, int>();
        public static int GameDetailsId { get; set; }
        public static int CurrentSeasonId { get; set; }
        public static int CurrentWeek { get; set; }
        public static int ManagedTeamId { get; set; }
        public static Formations Formations { get; set; }
        public static TeamTemplates TeamTemplates { get; set; }
    }

}
