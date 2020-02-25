using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenter.Models
{
    public class ClubList
    {
        public static List<Club> clubList  = new List<Club>()
            {
                new Club() {Name = "Grand Rapids", Address = "605 Leonard ST NW"},
                new Club() {Name = "Detroit", Address = "2918 W Davison St."},
                new Club() {Name = "Djibouti", Address = "H4VW+WF Djibouti"},
                new Club() {Name = "Kyoto", Address = "689 Nakagyo Ward"},
            };
        //Customized ToString for testing purposes.
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < clubList.Count(); i++)
            {
                s.Append(clubList[i].Name.ToString());
                if (i < clubList.Count() - 1)
                {
                    s.Append(", ");
                }
                else
                {
                    s.Append(".");
                }
            };
            return s.ToString();
        }
    }
}
