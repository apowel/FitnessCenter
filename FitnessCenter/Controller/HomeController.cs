using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitnessCenter.Models;
using FitnessCenter.Views;

namespace FitnessCenter.Controller
{
    public class HomeController
    {
        public HomeController()
        {
            foreach (var member in MemberList.GetMembersOf(Membership.Djibouti))
            {
                Console.WriteLine(member.Name);
            }
        }
    }
}
