using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Models
{
    public class MCMember : Member
    {
        public int Points { get; set; }
        public override void CheckIn(Club club)
        {
            throw new NotImplementedException();
        }
    }
}
