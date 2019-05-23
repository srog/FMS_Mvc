using System.ComponentModel.DataAnnotations;
using FMS3.Data.Cache;

namespace FMS3.Models
{
    public class GameDetails
    {
        public int Id { get; set; }
        [Display(Name = "Team Managed")]
        public int TeamId { get; set; }
        [Display(Name = "Manager Name")]
        public string ManagerName { get; set; }
        [Display(Name = "Current Season")]
        public int CurrentSeasonId { get; set; }
        [Display(Name = "Current Week")]
        public int CurrentWeek { get; set; }

        public string WeekDisplay => Utilities.Utilities.GetWeekDisplay(CurrentWeek);

        public bool IsPreSeason => (CurrentWeek == 0);
        public bool IsPostSeason => (CurrentWeek == (GameCache.NumberOfWeeksInSeason + 1));
        public bool CanAdvanceWeek => !IsPostSeason;
    }
}
