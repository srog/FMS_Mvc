namespace FMS3.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? SeasonId { get; set; }
        public int? Week { get; set; }
        public int? TeamFromId { get; set; }
        public int? TeamToId { get; set; }
        public int TransferValue { get; set; }
        public int GameDetailsId { get; set; }
        public int Status { get; set; }
        
    }
}
