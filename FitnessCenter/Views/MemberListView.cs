
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
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"ID: {list[i].Id}\tMembership Type: {list[i].Membership}");
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }
    }
}