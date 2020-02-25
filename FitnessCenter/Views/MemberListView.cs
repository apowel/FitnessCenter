using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Models;

namespace FitnessCenter.Views
{
    public class MemberListView
    {
        public static void MLView()
        {
            for (int i = 0; i < MemberList.memberList.Count; i++)
            {
                Console.WriteLine($"ID: {MemberList.memberList[i].Id}\tMembership Type: {MemberList.memberList[i].Membership}");
            }
        }
    }
}