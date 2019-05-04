using System.Collections.Generic;

namespace FMS3.Data
{
    public static class GlobalData
    {
        public static int GameDetailsId { get; set; }
        public static int CurrentSeasonId { get; set; }

        public static string[] TeamNames = new[]
            {
                "Manchester City",
                "Manchester Utd",
                "Liverpool",
                "Arsenal",
                "Norwich",
                "Aston Villa",
                "Cardiff City",
                "Leeds Utd",
                "Notts Forest",
                "Blackburn Rovers",
                "Sheffield Utd",
                "Wolves",
                "Oldham Athletic",
                "Portsmouth",
                "Shrewsbury Town",
                "Hartlepool Utd"
            };

        public static IEnumerable<int> GameTeamIdList = null;
   

    }
}
