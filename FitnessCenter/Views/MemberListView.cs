
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Models;

namespace FitnessCenter.Views
{
    public class MemberListView
    {
        public static void Display(List<Member> list)
        {
            Console.Clear();
            Console.WriteLine("Here are the members of our Fitness Center.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(String.Format("{0, -1}). ID: {1,-5} Name {2,-8} Membership Type: {3,-10}", $"{i + 1}", $"{list[i].Id}", $"{list[i].Name}",$"{list[i].Membership}"));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select a member from the list above.");

            //int decision = 0;
            //while (!Int32.TryParse(Console.ReadLine(), out decision)
            //    || decision < 1 || decision > (.Count + 1))
            //{
            //    Console.Clear();
            //    Console.WriteLine("That was not a Valid input");
            //    roster.GetUsers();
            //    Console.WriteLine($"{roster.users.Count + 1}: Create New Character");
            //}
        }
    }
}