using System.ComponentModel.DataAnnotations;

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

        public string WeekDisplay => (IsPreSeason ? "Pre-Season" : ( IsPostSeason ? "Post-Season" : CurrentWeek.ToString()));

        public bool IsPreSeason => (CurrentWeek == 0);
        public bool IsPostSeason => (CurrentWeek == 23);
        public bool CanAdvanceWeek { get; set; }
    }
}
