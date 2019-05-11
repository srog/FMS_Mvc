using System.Collections.Generic;

namespace FMS3.Data.Cache
{
    public static class GameCache
    {
        public static Dictionary<int, string> TeamNames = new Dictionary<int, string>();
        public static Dictionary<int, int> SeasonYear = new Dictionary<int, int>();
        public static int GameDetailsId { get; set; }
        public static int CurrentSeasonId { get; set; }
    }

}
