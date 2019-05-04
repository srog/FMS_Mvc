using System.ComponentModel.DataAnnotations;

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
    }
}
