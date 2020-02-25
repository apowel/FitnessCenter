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
            for (int i = 0; i < ClubList.clubList.Count; i++)
            {
                Console.WriteLine($"Name: {ClubList.clubList[i].Name}\tAddress: {ClubList.clubList[i].Address}");
            }
        }
    }
}
