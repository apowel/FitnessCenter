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
            Console.WriteLine("1. Take a look at the list of available clubs");
            Console.WriteLine("2. Take a look at the members of the fitness centers");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}