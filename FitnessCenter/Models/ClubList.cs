using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Models
{
    public class ClubList
    {
        public static List<Club> clubList = new List<Club>()
        {
            new Club() {Name = "Grand Rapids", Address = "605 Leonard ST NW"},
            new Club() {Name = "Detroit", Address = "2918 W Davison ST"},
            new Club() {Name = "Djibouti", Address = "H4VW+WF Djibouti"},
            new Club() {Name = "Kyoto", Address = "689 Nakagyo Ward"},
        };
    }
}
