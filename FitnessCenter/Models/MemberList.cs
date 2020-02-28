using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenter.Models
{
    public class MemberList
    {
        public static List<Member> memberList = new List<Member>()
        {
            new SCMember() { Id = 1234, Name = "Andrew", Membership = Membership.GrandRapids },
            new SCMember() { Id = 7138, Name = "Austin", Membership = Membership.Djibouti },
            new MCMember() { Id = 3825, Name = "Tommy", Membership = Membership.MultiClub },
            new SCMember() { Id = 2678, Name = "Naruto", Membership = Membership.Kyoto }
        };
        public static void Signup(Member member)
        {
            // make validation to prevent duplicate Id's.
            Random id = new Random();
            member.Id = id.Next(1000, 9999);
            memberList.Add(member);
        }
        public static void Remove(Member member)
        {
            memberList.Remove(member);
        }
        public static Member GetMember(string name)
        {
            return memberList.FirstOrDefault(e => e.Name == name);
        }
        public static Member GetMember()
        {
            int decision = 0;
            while (!Int32.TryParse(Console.ReadLine(), out decision)
                || decision < 1000|| decision > 9999)
            {
                Console.Clear();
                Console.WriteLine("That member does not exist.");
            }
            return memberList.FirstOrDefault(e => e.Id == decision);
        }

        //returns a list of members of a gym and includes multiclub members.
        public static List<Member> GetMembersOf(Membership m)
        {
            return memberList.Where(e => e.Membership == m || 
            e.Membership == Membership.MultiClub).ToList();
        }

        // add file.io saving implemenation here?


        //Customized ToString for testing purposes.
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < memberList.Count(); i++)
            {
                s.Append(memberList[i].Name);
                if (i < memberList.Count() - 1)
                {
                    s.Append(", ");
                }
                else
                {
                    s.Append(".");
                }
            }
            return s.ToString();
        }
    }
}
