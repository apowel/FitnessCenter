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
        public HomeController()
        {
            MasterRouting(IndexRoute());
        }
        private void MasterRouting(int i)
        {
            switch (i)
            {
                case 1:
                    Index.Introduction();
                    break;
                case 2:
                    ClubListView.CLView();
                    break;
                case 3:
                    MemberListView.MLView();
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
    }
}
