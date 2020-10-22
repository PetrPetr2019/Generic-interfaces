using System;
using System.Collections.Generic;

namespace StaffSport
{
    public partial class Sportsman
    {
        public int SportsmanId { get; set; }
        public string SportsmanName { get; set; }
        public int? Rank { get; set; }
        public string YearOfBirth { get; set; }
        public int? PersonalRecord { get; set; }
        public string Country { get; set; }
    }
}
