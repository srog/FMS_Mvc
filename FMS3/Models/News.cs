
namespace FMS3.Models
{
    public class News
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int GameDetailsId { get; set; }
        public int SeasonId { get; set; }
        public int DivisionId { get; set; }
        public string NewsText { get; set; }
    }
}
