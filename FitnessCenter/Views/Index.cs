using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Views;

namespace FitnessCenter.Views
{
    public class Index
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Fitness Application :: What would you like to do?");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Select a club");
            Console.WriteLine("2. See all registered members");
            Console.WriteLine("3. Exit to desktop");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}