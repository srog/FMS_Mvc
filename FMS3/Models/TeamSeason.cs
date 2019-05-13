
using System.ComponentModel.DataAnnotations;

namespace FMS3.Models
{
    public class TeamSeason
    {
        public int Id { get; set; }
        [Display(Name = "Team Name")]
        public int TeamId { get; set; }
        public int GameDetailsId { get; set; }
        public int DivisionId { get; set; }
        public int SeasonId { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        [Display(Name = "Goal Diff")]
        public int GoalDifference => GoalsFor - GoalsAgainst;
        public int Points { get; set; }
        public int Position { get; set; }




    }
}
