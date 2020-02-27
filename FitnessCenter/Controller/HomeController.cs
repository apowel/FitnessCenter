using System;
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
        private void MasterRouting(int i)
        {
            switch (i)
            {
                case 1:
                    CLVRoute();
                    break;
                case 2:
                    MLVRoute();
                    break;
                case 3:
                    ClubViewRoute();
                    break;
                case 4:
                    MemberViewRoute();
                    break;
                case 5:
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
                MasterRouting(1);
            }
            else if (input == "2")
            {
                MasterRouting(2);
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
            int decision = 0;
            while (!Int32.TryParse(Console.ReadLine(), out decision)
                || decision < 1 || decision > (ClubList.clubList.Count))
            {
                Console.Clear();
                Console.WriteLine("That was not a Valid input");
                ClubListView.Display();
            }
            ClubList.SetCurrentClub(decision);
            MasterRouting(3);
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
                MasterRouting(5);
            }
            else if (input == "3")
            {
                MasterRouting(2);
            }
            else if (input == "4")
            {
                MasterRouting(default);
            }
            else
            {
                Console.WriteLine("That is not a valid response, please try again.");
                MasterRouting(3);
            }

        }
        
        private void MLVRoute()
        {
            try
            {
                MemberListView.Display(MemberList.GetMembersOf(currentClub.Membership));
                MasterRouting(3);
            }
            catch (Exception)
            {
                MemberListView.Display(MemberList.memberList);
                MasterRouting(default);
            }
            
        }
        
        private void MemberViewRoute()
        {
            //this route is not yet implemented
            MasterRouting(default);
        }
        
        private void AddMemberViewRoute()
        {
            AddMemberView.Display(currentClub);
            MemberList.Signup(currentMember);
            MasterRouting(default);
        }
        
    }
}
