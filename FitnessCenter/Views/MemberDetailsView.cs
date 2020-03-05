using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Models;
using FitnessCenter.Controller;

namespace FitnessCenter.Views
{
    class MemberDetailsView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"Member ID: {HomeController.currentMember.Id}");
            Console.WriteLine($"Member Name: {HomeController.currentMember.Name}");
            Console.WriteLine($"Home Club: {HomeController.currentMember.Membership}");
            Console.WriteLine($"Outstanding Balance: {MemberList.GetBalance():C}");
            if (HomeController.currentMember.Membership == Membership.MultiClub)
            {
                MCMember placeHolder = (MCMember)HomeController.currentMember;
                Console.WriteLine($"Points: {placeHolder.Points}");
            }
            else
            {
            }
            Console.WriteLine("\n~~Select one of the following options~~");
            Console.WriteLine("\n1: Settle outstanding bill.");
            Console.WriteLine("2: Delete member.");
            Console.WriteLine("3: Return to the previous menu.");
        }
    }
}
