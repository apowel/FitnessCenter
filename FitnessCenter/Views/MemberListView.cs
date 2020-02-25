using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Models;

namespace FitnessCenter.Views
{
    public class MemberListView
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Here are the members of our Fitness Center.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < MemberList.memberList.Count; i++)
            {
                Console.WriteLine(String.Format("{0, -1}). ID: {1,-5} Membership Type: {2,-10}", $"{i+1}", $"{MemberList.memberList[i].Id}", $"{MemberList.memberList[i].Membership}"));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select a member from the list above.");
            string input = Console.ReadLine();

            //Change to the while loop in Slack.
            if (input == "1")
            {
                
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
