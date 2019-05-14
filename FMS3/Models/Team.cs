using System.ComponentModel.DataAnnotations;

namespace FMS3.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Year Formed")]
        public int YearFormed { get; set; }
        [Display(Name = "Division")]
        public int DivisionId { get; set; }
        [Display(Name = "Funds")]
        public int Cash { get; set; }
        [Display(Name = "Stadium Capacity")]
        public int StadiumCapacity { get; set; }
        public int GameDetailsId { get; set; }
        public int FormationId { get; set; }
    }
}
