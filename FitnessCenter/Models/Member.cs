using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Models
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Membership Membership { get; set; }
        public abstract void CheckIn(Club club);
        public int Price { get; set; }
        public  DateTime Begin { get; set; }

    }
}