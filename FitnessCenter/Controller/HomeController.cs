using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
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
            GetMemberList();
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
                case "MemberDetailsViewRoute":
                    MemberDetailsViewRoute();
                    break;
                case "AddMemberViewRoute":
                    AddMemberViewRoute();
                    break;
                case "MemberCheckInViewRoute":
                    MemberCheckInViewRoute();
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
                WriteXML(MemberList.memberList);
                Environment.Exit(0);
            }
            else
            {
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
                    MasterRouting("MemberCheckInViewRoute");
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
                MemberList.GetMember();
                MasterRouting("MemberDetailsViewRoute");
            }
            catch (NullReferenceException)
            {
                MemberListView.Display(MemberList.memberList);
                try
                {
                    MemberList.GetMember();
                    MasterRouting("MemberDetailsViewRoute");
                }
                catch (Exception)
                {
                    MasterRouting(default);
                }
            }
            catch (Exception)
            {
                MasterRouting("ClubViewRoute");
            }
        }
        private void MemberDetailsViewRoute()
        {
            MemberDetailsView.Display();
            Member.MemberMenu(currentMember);
            MasterRouting("ClubViewRoute");
        }
        private void MemberCheckInViewRoute()
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
        private static void WriteXML(List<Member> memberList)
        {
            var path = "MemberList.XML";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Member>));
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, memberList);
            writer.Close();
        }
        private static List<Member> ReadFromXmlFile(string path)
        {
            object obj = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Member>));
            if (File.Exists(path))
            {
                TextReader textReader = new StreamReader(path);
                obj = serializer.Deserialize(textReader);
                textReader.Close();
            }
            return (List<Member>)obj;
        }
        private void GetMemberList()
        {
            if (File.Exists("MemberList.XML"))
            {
                MemberList.memberList = ReadFromXmlFile("MemberList.XML");
            }
        }
    }
}
