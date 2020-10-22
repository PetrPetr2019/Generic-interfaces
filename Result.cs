using System;
using System.Collections.Generic;

namespace StaffSport
{
    public partial class Result
    {
        public int CompetitionId { get; set; }
        public int? SportsmanId { get; set; }
        public int? Result1 { get; set; }
        public string City { get; set; }
        public DateTime? HoldDate { get; set; }
    }
}
