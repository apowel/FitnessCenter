using FitnessCenter.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Models
{
    public class SCMember : Member
    {
        public override void CheckIn(Club club)
        {
            if ((int)HomeController.currentMember.Membership == club.Id - 1)
            {
                Console.WriteLine("Success!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not success");
                Console.ReadKey();
            }
        }
    }
}
