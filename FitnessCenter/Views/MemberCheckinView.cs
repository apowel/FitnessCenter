using FitnessCenter.Controller;
using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class MemberCheckinView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"Member ID: {HomeController.currentMember.Id}");
            Console.WriteLine($"Member Name:{HomeController.currentMember.Name}");
            Console.WriteLine($"Home Club: {HomeController.currentMember.Membership}");
            
            
            MCMember placeHolder = (MCMember)HomeController.currentMember;
            TimeSpan remainder = DateTime.Today.Subtract(placeHolder.Begin);
            TimeSpan billing = remainder * placeHolder.Price;

            if (HomeController.currentMember.Membership == Membership.MultiClub)
            {
                
                Console.WriteLine("Welcome!");
                Console.WriteLine($"Points: {placeHolder.Points}\n");
                Console.WriteLine($"Membership Price: {placeHolder.Price}");
                Console.WriteLine($"Start Date: {placeHolder.Begin}");
                Console.WriteLine($"Current Date: {DateTime.Today}\n");
                Console.WriteLine($"Your current balance is: {billing}");
            }
            else
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine($"Membership Price: {placeHolder.Price}");
                Console.WriteLine($"Start Date: {placeHolder.Begin}");
                Console.WriteLine($"Current Date: {DateTime.Today}\n");
                Console.WriteLine($"Your current balance is: {billing}");

            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
