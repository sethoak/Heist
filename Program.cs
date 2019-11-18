using System;
using System.Collections.Generic;

namespace Heist1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");

            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            Console.WriteLine("Enter your team member's name");
            string name = Console.ReadLine();
            teamMember.Add("Name", name);

            Console.WriteLine("Enter your team member's skill level");
            string skillLevel = Console.ReadLine();
            teamMember.Add("Skill Level", skillLevel);

            Console.WriteLine("Enter your team member's courage factor");
            string courageFactor = Console.ReadLine();
            teamMember.Add("Courage Factor", courageFactor);

            foreach (KeyValuePair<string, string> attribute in teamMember)
            {
                Console.WriteLine($"{attribute.Key}: {attribute.Value}");
            }
        }
    }
}