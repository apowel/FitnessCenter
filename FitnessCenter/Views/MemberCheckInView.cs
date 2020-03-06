using FitnessCenter.Controller;
using FitnessCenter.Models;
using System;
using FitnessCenter.Models;


namespace FitnessCenter.Views
{
    public static class MemberCheckInView
    {
        public static int MonthDifference(this DateTime lValue, DateTime rValue)
        {
            int monthResult = (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year);
            return monthResult;
        }
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"Member ID: {HomeController.currentMember.Id}");
            Console.WriteLine($"Member Name:{HomeController.currentMember.Name}");
            Console.WriteLine($"Home Club: {HomeController.currentMember.Membership}");

            

            if (HomeController.currentMember.Membership == Membership.MultiClub)
            {
                MCMember placeHolder = (MCMember)HomeController.currentMember;
                int billing = MonthDifference(DateTime.Today, placeHolder.Begin) * placeHolder.Price;
                Console.WriteLine("Welcome!");
                Console.WriteLine($"Points: {placeHolder.Points}\n");
                Console.WriteLine($"Membership Price: {placeHolder.Price}");
                Console.WriteLine($"Start Date: {placeHolder.Begin}");
                Console.WriteLine($"Current Date: {DateTime.Today}\n");
                Console.WriteLine($"Your current amount due is:{billing} ");
            }
            else
            {
                SCMember placeHolder = (SCMember)HomeController.currentMember;
                int billing = MonthDifference(DateTime.Today, placeHolder.Begin) * placeHolder.Price;
                Console.WriteLine("Welcome!");
                Console.WriteLine($"Membership Price: {HomeController.currentMember.Price}");
                Console.WriteLine($"Start Date: {HomeController.currentMember.Begin}");
                Console.WriteLine($"Current Date: {DateTime.Today}\n");
                Console.WriteLine($"Your current amount due is: {billing}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
