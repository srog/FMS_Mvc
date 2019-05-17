using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FMS3.Models
{
    public class FixtureInfo
    {
        public int Week { get; set; }
        public int CurrentWeek { get; set; }
        public List<SelectListItem> WeekList { get; set; }
        public string SelectedWeek { get; set; }
        public FixtureInfo()
        {
            Week = 0;
            SelectedWeek = "0";
            WeekList = new List<SelectListItem>();
        }

        public FixtureInfo(int week)
        {
            Week = week;
            SelectedWeek = week.ToString();
            WeekList = new List<SelectListItem>();
        }
    }

    public class FixtureList
    {
        public IEnumerable<Match> Fixtures { get; set; }
        public int CurrentWeek { get; set; }
    }

}
