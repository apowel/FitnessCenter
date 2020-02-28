
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
                Console.WriteLine(String.Format("{0, -1}). ID: {1,-5} Name {2,-8} " +
                    "Membership Type: {3,-10}",
                    $"{i + 1}", $"{list[i].Id}",
                    $"{list[i].Name}",
                    $"{list[i].Membership}"));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Select a member by typing their Id number.");
            
            /*int decision = 0;

            while (!Int32.TryParse(Console.ReadLine(), out decision)
                || decision < 1 || decision > (list.Count))
            {
                Console.WriteLine("Invalid response, please try again! (Press \"enter\" to try again)");
                Console.ReadLine();
                Console.Clear();
                Display(list);
            }*/

        }
    }
}