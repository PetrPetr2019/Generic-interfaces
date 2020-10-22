using System;
using System.Collections.Generic;

namespace StaffSport
{
    public partial class Competition
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public int? WorldRecord { get; set; }
        public string SetDate { get; set; }
    }
}
