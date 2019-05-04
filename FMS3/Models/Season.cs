using System.ComponentModel.DataAnnotations;

namespace FMS3.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int GameDetailsId { get; set; }
        [Display(Name = "Year")]
        public int StartYear { get; set; }
        public bool Completed { get; set; }
    }
}
