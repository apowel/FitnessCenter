using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenter.Models
{
    public class MemberList
    {
        public List<Member> memberList;
        public MemberList()
        {
            memberList = new List<Member>()
            {
            new SCMember() { Id = 1234, Name = "Andrew", Membership = Membership.GrandRapids },
            new SCMember() { Id = 7138, Name = "Austin", Membership = Membership.Djibouti },
            new SCMember() { Id = 3825, Name = "Tommy", Membership = Membership.MultiClub },
            new SCMember() { Id = 2678, Name = "Naruto", Membership = Membership.Kyoto }
            };
        }
        public Member Add(Member member)
        {
            // change to make id set as random 4 digit number
            member.Id = memberList.Max(e => e.Id) + 1;
            memberList.Add(member);
            return member;
        }
        public Member GetMember(string name)
        {
            return memberList.FirstOrDefault(e => e.Name == name);
        }
        // add file.io saving implemenation here?
    }
}
