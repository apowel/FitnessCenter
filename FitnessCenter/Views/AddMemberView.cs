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
            
            Console.WriteLine("Would you like a Single-Club, or a Multi-Club Membership?");
            Console.WriteLine("||Select \"1\" for Single-Club or \"2\" for Multi-Club||");
            Member.GetNewMemberType(HomeController.currentClub);
            Console.WriteLine("What is your name:");
            Member.GetNewName();
        }
    }
}
