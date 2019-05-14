using System.Collections.Generic;

namespace FMS3.Models
{
    public class Formations
    {
        public List<Formation> FormationList { get; set; }
    }
    public class Formation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Defenders { get; set; }
        public int Midfielders { get; set; }
        public int Attackers { get; set; }
        
    }
}
