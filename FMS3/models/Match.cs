
using System.ComponentModel.DataAnnotations;

namespace FMS3.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int GameDetailsId { get; set; }
        public int SeasonId { get; set; }
        public int DivisionId { get; set; }
        [Display(Name = "Week No.")]
        public int Week { get; set; }
        [Display(Name = "Home Team")]
        public int HomeTeamId { get; set; }
        [Display(Name = "Away Team")]
        public int AwayTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public bool Completed { get; set; }
    }
}
