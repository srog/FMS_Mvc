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

        public string WeekDisplay => (CurrentWeek == 0 ? "Pre-Season" : CurrentWeek.ToString());

    }
}
