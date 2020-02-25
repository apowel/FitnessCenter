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
        private Club currentClub;
        private Member currentMember;
        public HomeController()
        {
            MasterRouting(IndexRoute());
        }
        private void MasterRouting(int i)
        {
            switch (i)
            {
                case 1:
                    IndexRoute();
                    break;
                case 2:
                    CLVRoute();
                    break;
                case 3:
                    MLVRoute();
                    break;
                case 4:
                    ClubViewRoute();
                    break;
                case 5:
                    MemberViewRoute();
                    break;
                case 6:
                    AddMemberViewRoute();
                    break;
                default:
                    Index.Introduction();
                    break;
            }
        }
        private int IndexRoute()
        {
            Index.Introduction();
            string input = Console.ReadLine();

            if (input == "1")
            {
                return 2;
            }
            else if (input == "2")
            {
                return 3;
            }
            else
            {
                Console.WriteLine("Invalid response, please try again! (Press \"enter\" to try again)");
                Console.ReadLine();
                Console.Clear();
                return IndexRoute();
            }
        }
        private int CLVRoute()
        {

        }
        private int ClubViewRoute()
        {

        }
        private int MLVRoute()
        {

        }
        private int MemberViewRoute()
        {

        }
        private int AddMemberViewRoute()
        {

        }
    }
}
