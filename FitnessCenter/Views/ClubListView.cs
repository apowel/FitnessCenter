using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class ClubListView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Here is the list of available clubs.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < ClubList.clubList.Count; i++)
            {
                Console.WriteLine(String.Format("{0, -1}). Name: {1,-15} Address: {2,-10}", $"{i + 1}", $"{ClubList.clubList[i].Name}", $"{ClubList.clubList[i].Address}"));
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select a club from the list above.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                ClubView.Display(ClubList.clubList[0]);
            }
            else if (input == "2")
            {
                Console.Clear();
                ClubView.Display(ClubList.clubList[1]);
            }
            else if (input == "3")
            {
                Console.Clear();
                ClubView.Display(ClubList.clubList[2]);
            }
            else if (input == "4")
            {
                Console.Clear();
                ClubView.Display(ClubList.clubList[3]);
            }
            else
            {
                Console.WriteLine("Invalid response, please try again! (Press \"enter\" to try again)");
                Console.ReadLine();
                Console.Clear();
                Display();
            }
        }
    }
}
