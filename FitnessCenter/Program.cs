using System;
using FitnessCenter.Controller;
using FitnessCenter.Models;
﻿using FitnessCenter.Views;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeController controller = new HomeController();
            /*HomeController.currentMember = MemberList.memberList[1];
            Console.WriteLine(MemberList.GetBalance());*/
        }
    }
}
