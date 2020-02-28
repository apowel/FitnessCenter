﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitnessCenter.Models;
using FitnessCenter.Views;
using Index = FitnessCenter.Views.Index;

namespace FitnessCenter.Controller
{
    public class HomeController
    {
        //use these variables to store and call objects for ClubView and MemberDetailsView.
        public static Club currentClub;
        public static Member currentMember;
        public HomeController()
        {
            MasterRouting(default);
        }
        private void MasterRouting(string route)
        {
            switch (route)
            {
                case "CLVRoute":
                    CLVRoute();
                    break;
                case "MLVRoute":
                    MLVRoute();
                    break;
                case "ClubViewRoute":
                    ClubViewRoute();
                    break;
                case "MemberViewRoute":
                    MemberViewRoute();
                    break;
                case "AddMemberViewRoute":
                    AddMemberViewRoute();
                    break;
                default:
                    IndexRoute();
                    break;
            }
        }
        private void IndexRoute()
        {
            Console.Clear();
            currentMember = null;
            currentClub = null;
            Index.Introduction();
            string input = Console.ReadLine();

            if (input == "1")
            {
                MasterRouting("CLVRoute");
            }
            else if (input == "2")
            {
                MasterRouting("MLVRoute");
            }
            else if (input == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid response, please try again! (Press \"enter\" to try again)");
                Console.ReadLine();
                Console.Clear();
                MasterRouting(default);
            }
        }
        
        private void CLVRoute()
        {
            ClubListView.Display();
            ClubList.SetCurrentClub();
            MasterRouting("ClubViewRoute");
        }
        
        private void ClubViewRoute()
        {
            ClubView.Display(currentClub);
            string input = Console.ReadLine();

            if (input == "1")
            {
                string name;
                Console.WriteLine("Please enter the name of the member");
                name = Console.ReadLine();
                try
                {
                    currentMember = MemberList.GetMember(name);
                    currentMember.CheckIn(currentClub);
                    MasterRouting("MemberViewRoute");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: That person is not registered at this location.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    ClubViewRoute();
                }
                MasterRouting(default);
            }
            else if (input == "2")
            {
                MasterRouting("AddMemberViewRoute");
            }
            else if (input == "3")
            {
                MasterRouting("MLVRoute");
            }
            else if (input == "4")
            {
                MasterRouting(default);
            }
            else
            {
                Console.WriteLine("That is not a valid response, please try again.");
                MasterRouting("ClubViewRoute");
            }
        }
        private void MLVRoute()
        {
            try
            {
                MemberListView.Display(MemberList.GetMembersOf(currentClub.Membership));
                currentMember = MemberList.GetMember();
                MasterRouting("ClubViewRoute");
            }
            catch (Exception)
            {
                MemberListView.Display(MemberList.memberList);
                currentMember = MemberList.GetMember();
                try
                {
                    MasterRouting("MemberViewRoute");
                }
                catch (Exception)
                {
                    MasterRouting(default);
                }
            }
        }
        
        private void MemberViewRoute()
        {
            MemberCheckInView.Display();
            MasterRouting("ClubViewRoute");
        }
        
        private void AddMemberViewRoute()
        {
            AddMemberView.Display(currentClub);
            MemberList.Signup(currentMember);
            MasterRouting("ClubViewRoute");
        }
    }
}
