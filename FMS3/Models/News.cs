
using System.ComponentModel.DataAnnotations;

namespace FMS3.Models
{
    public class News
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int GameDetailsId { get; set; }
        public int SeasonId { get; set; }
        public int DivisionId { get; set; }
        [Display(Name = "Current Week")]
        public int Week { get; set; }
        [Display(Name = "News")]
        public string NewsText { get; set; }

        public string WeekDisplay => (Week == 0 ? "Pre-Season" : (Week == 23 ? "Post-Season" : Week.ToString()));

    }
}
