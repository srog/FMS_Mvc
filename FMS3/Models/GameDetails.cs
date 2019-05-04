using System;

namespace FMS3.Models
{
    public class GameDetails
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string ManagerName { get; set; }
        public int CurrentSeasonId { get; set; }
        public int CurrentWeek { get; set; }

    }
}
