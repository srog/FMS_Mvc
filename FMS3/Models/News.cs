
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
        public int PlayerId { get; set; }
        [Display(Name = "Current Week")]
        public int Week { get; set; }
        [Display(Name = "News")]
        public string NewsText { get; set; }

        public string WeekDisplay => (Week == 0 ? "Pre-Season" : (Week == 23 ? "Post-Season" : Week.ToString()));

    }


    public class PlayerNews
    {
        public News News { get; set; }
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public int Weeks { get; set; }
    }

    public class PromotionNews
    {
        public News News { get; set; }
        public string TeamName { get; set; }
        public int Division { get; set; }
    }
}
