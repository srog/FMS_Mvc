using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FMS3.Enums;

namespace FMS3.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Overall Rating")]
        public int Rating { get; set; }
        public int Age { get; set; }
        public int Position { get; set; }
        public int TeamId { get; set; }
        public int Value { get; set; }
        public bool Retired { get; set; }
        [Display(Name = "Weeks Injured")]
        public int InjuredWeeks { get; set; }
        public int GameDetailsId { get; set; }
        public int TeamSelection { get; set; }
        public bool IsSelected => (TeamSelection > 0);
        public string ShortName => Name.Split(" ")[0][0] + "." + Name.Split(" ")[1];    
    }

    public class PlayerListDisplay
    {
        public List<Player> PlayerList { get; set; }
        public PlayerListDisplayTypeEnum DisplayType { get; set; }
        public string TeamName { get; set; }
        public int TeamFormationId { get; set; }
        public string TeamFormation { get; set; }
        public bool IsPreSeason { get; set; }
        public bool IsPostSeason { get; set; }
    }
}
