using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; private set; }
        public double Courage { get; private set; }
        public TeamMember(string name, int skillLevel, double courage)
        {
            Name = name;
            SkillLevel = skillLevel;
            Courage = courage;
        }
        public void ShowMemberInfo()
        {
            Console.WriteLine($"Your First team member {Name} has a skill level of {SkillLevel} and a courage level of {Courage}");
        }
    }
}
