using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Views
{
    public class ClubListView
    {
        public static void CLView()
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
        }
    }
}