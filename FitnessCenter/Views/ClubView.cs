using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class ClubView
    {
        public static void CView(Club club)
        {
            Console.WriteLine($"Welcome to {club.Name} Fitness Center!");
            Console.WriteLine("1. Check in as a member\n2. Add a new member\n3. View the current list of members\n4. Return to the Main Menu");

            string input = Console.ReadLine();

            if(input == "1")
            {

            }
            else if(input == "2")
            {

            }
            else if(input == "3")
            {

            }
            else if(input == "4")
            {
                Index.Introduction();
            }
            else
            {
                Console.WriteLine("That is not a valid response, please try again.");

            }
        }
    }
}
