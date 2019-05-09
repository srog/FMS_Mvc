using System.Collections.Generic;

namespace FMS3.Models
{
    public class MatchDetail
    {
        public Match Match { get; set;  }
        public IEnumerable<MatchGoal> Goals { get; set; }
        public IEnumerable<MatchEvent> Events { get; set; }
    }
}
