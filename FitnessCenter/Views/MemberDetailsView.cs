using FitnessCenter.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class MemberDetailsView
    {
        public static void Display()
        {
            Console.WriteLine($"Member ID: {HomeController.currentMember.Id}");
            Console.WriteLine($"Member Name:{HomeController.currentMember.Name}");
            Console.WriteLine($"Home Club: {HomeController.currentMember.Membership}");
        }
    }
}
