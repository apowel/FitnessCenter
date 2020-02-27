using FitnessCenter.Controller;
using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class AddMemberView
    {
        public static void Display(Club club)
        {
            Console.Clear();
            Console.WriteLine($"{club.Name} Fitness Center :: Add a New Member");
            Console.WriteLine("Let's add a new member!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("What is your name:");
            Random id = new Random();
            
            string name = Console.ReadLine();

            Console.WriteLine("Would you like a Single-Club, or a Multi-Club Membership?");
            Console.WriteLine("||Select \"1\" for Single-Club or \"2\" for Multi-Club||");
            string memType = Console.ReadLine();

            if (memType == "1")
            {
                SCMember newMember = new SCMember() { Name = name, Membership = club.Membership, 
                                                    Id =  id.Next(1000, 9999)};
                HomeController.currentMember = newMember;
            }
            else if (memType == "2")
            {
                MCMember newMember = new MCMember() { Name = name, Membership = Membership.MultiClub, 
                                                    Id = id.Next(1000, 9999) };
                HomeController.currentMember = newMember;
            }
            else
            {
                Console.WriteLine("That is not a valid answer, please try again.");
                Console.ReadKey();
                Display(club);
            }
        }
    }
}
