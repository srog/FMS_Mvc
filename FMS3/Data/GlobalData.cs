using System.Collections.Generic;

namespace FMS3.Data
{
    public static class GlobalData
    {
        public static int GameDetailsId { get; set; }
        public static int CurrentSeasonId { get; set; }

        public static Dictionary<string, object> GameDetailParamList = new Dictionary<string, object>
            {
                {"gameDetailsId", GlobalData.GameDetailsId}
            };

        public static Dictionary<string, object> SeasonParamList = new Dictionary<string, object>
            {
                {"gameDetailsId", GlobalData.GameDetailsId},
                {"seasonId", GlobalData.CurrentSeasonId}
            };
    }
}
