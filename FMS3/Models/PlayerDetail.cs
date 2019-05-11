using System.Collections.Generic;

namespace FMS3.Models
{
    public class PlayerDetail
    {
        public bool OwnPlayer { get; set; }
        public Player Player { get; set; }
        public PlayerStats PlayerStats { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
    }
}
