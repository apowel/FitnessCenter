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
            Console.Clear();
            Console.WriteLine($"Welcome to {club.Name} Fitness Center!");
            Console.WriteLine("1. Check in as a member\n2. Add a new member\n3. View the current list of members\n4. Return to the Main Menu");
            Console.ReadKey();
            
        }
    }
}