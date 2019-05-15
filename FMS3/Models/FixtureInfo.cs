using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FMS3.Models
{
    public class FixtureInfo
    {
        public int Week { get; set; }
        public List<SelectListItem> WeekList { get; set; }

        public FixtureInfo(int week)
        {
            Week = week;
            WeekList = new List<SelectListItem>();
        }
    }
}
