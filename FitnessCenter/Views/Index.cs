using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Views;

namespace FitnessCenter.Views
{
    public class Index
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Fitness Application :: What would you like to do?");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Take a look at the list of available clubs");
            Console.WriteLine("2. Take a look at the members of the fitness centers");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string input = Console.ReadLine();

            if (input == "1")
            {
                 ClubListView.CLView();
            }
            else if (input == "2")
            {
                MemberListView.MLView();
            }
            else
            {
                Console.WriteLine("Invalid response, please try again! (Press \"enter\" to try again)");
                Console.ReadLine();
                Console.Clear();
                Introduction();
            }
        }
    }
}
