using FitnessCenter.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Models
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Membership Membership { get; set; }
        public int Price { get; set; }
        public abstract void CheckIn(Club club);
        public static void MemberMenu(Member member)
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                member.Price = 0;
                Console.WriteLine($"{member.Name} has paid their bill!");
                MemberDetailsView.Display();
                MemberMenu(member);
                return;
            }
            else if (input == "2")
            {
                MemberList.memberList.Remove(member);
                Console.WriteLine($"{member.Name} has been deleted from our records.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }
            else if (input == "3")
            {
                return;
            }
        }
    }
}
