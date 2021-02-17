using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What difficulty level do you want the bank to be?");
            //Converted string to int
            var difficulty = int.Parse(Console.ReadLine());
            //List to hold the team members
            var yourTeam = new List<TeamMember> { };
            //Set a bool to use to check if the user input was blank
            bool isBlank = true;
            //While loop to break if the user input is blank
            while (isBlank)
            {
                Console.WriteLine("Enter a Team Member's Name");
                var memberName = Console.ReadLine();
                //.IsNullOrEmpty returns bool to check to see if the user input is empty
                if (String.IsNullOrEmpty(memberName))
                {
                    isBlank = false;
                    break;
                }

                Console.WriteLine("Enter the Team Member's Skill Level 0-100");
                var memberSkill = Console.ReadLine();
                if (String.IsNullOrEmpty(memberSkill))
                {
                    isBlank = false;
                    break;
                }
                var toIntMemberSkill = int.Parse(memberSkill);

                Console.WriteLine("Enter the Team Member's Courage Level 0-2.0");
                var memberCourage = Console.ReadLine();
                if (String.IsNullOrEmpty(memberCourage))
                {
                    isBlank = false;
                    break;
                }
                var toDoubleMemberCourage = double.Parse(memberCourage);
                //Adding the team members to the list
                var teamMember = new TeamMember(memberName, toIntMemberSkill, toDoubleMemberCourage);
                yourTeam.Add(teamMember);
            }
            Console.WriteLine($"There are {yourTeam.Count} members in your team!");

            Console.WriteLine("How many times do you want to run the scenario?");
            var numOfScenarios = Console.ReadLine();
            var counter = 0;
            var success = 0;
            var fail = 0;

            while (int.Parse(numOfScenarios) > counter)
            {
                var teamSkillLevel = 0;
                var random = new Random();
                int luck = random.Next(-10, 10);
                difficulty += luck;

                foreach (var member in yourTeam)
                {
                    teamSkillLevel += member.SkillLevel;
                }

                Console.WriteLine($"The teams combined skill level is {teamSkillLevel}");
                Console.WriteLine($"The banks difficulty level is {difficulty}");

                if (teamSkillLevel >= difficulty)
                {
                    Console.WriteLine("Success");
                    success++;
                }
                else
                {
                    Console.WriteLine("Fail");
                    fail++;
                }
                counter++;
            }
            Console.WriteLine($"The bank was robbed {success} times and you went to jail {fail} times. Thanks for playing!!");
        }
    }
}
