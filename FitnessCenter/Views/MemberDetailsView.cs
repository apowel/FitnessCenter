using FitnessCenter.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Models;
using FitnessCenter.Controller;

namespace FitnessCenter.Views
{
    public class MemberDetailsView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"Member ID: {HomeController.currentMember.Id}");
            Console.WriteLine($"Member Name:{HomeController.currentMember.Name}");
            Console.WriteLine($"Home Club: {HomeController.currentMember.Membership}");
            if (HomeController.currentMember.Membership == Membership.MultiClub)
            {
                MCMember placeHolder = (MCMember)HomeController.currentMember;
                Console.WriteLine($"Points: {placeHolder.Points}");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
