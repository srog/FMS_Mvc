using System.ComponentModel.DataAnnotations;

namespace FMS3.Enums
{
    public enum DivisionEnum
    {
        [Display(Name = "Premier League")]
        PremierLeague = 1,
        [Display(Name = "Championship")]
        Championship = 2,
        [Display(Name = "League One")]
        LeagueOne = 3,
        [Display(Name = "League Two")]
        LeagueTwo = 4
    }
}
