using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Models
{
    public class GameDetails
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string ManagerName { get; set; }
        public int CurrentYear { get; set; }
        public int CurrentWeek { get; set; }

    }
}
