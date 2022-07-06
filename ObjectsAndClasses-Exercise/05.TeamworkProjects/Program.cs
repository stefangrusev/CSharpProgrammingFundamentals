using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int counter = int.Parse(Console.ReadLine());
                List<Team> teams = new List<Team>(counter);
                string user = string.Empty;
                string name = string.Empty;

                for (int i = 1; i <= counter; i++)
                {
                    var command = Console.ReadLine().Split("-").ToArray();
                    user = command[0];
                    name = command[1];

                    if (teams.Any(x => x.TeamName == name))
                    {
                        Console.WriteLine($"Team {name} was already created!");
                    }
                    else if (teams.Any(x => x.Creator == user))
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team(name, user);
                        teams.Add(team);
                        Console.WriteLine($"Team {name} has been created by {user}!");
                    }
                }

                string input = Console.ReadLine();

                while (input != "end of assignment")
                {
                    var command = input.Split("->").ToArray();
                    user = command[0];
                    name = command[1];

                    if (!teams.Any(x => x.TeamName == name))
                    {
                        Console.WriteLine($"Team {name} does not exist!");
                    }
                    else if (teams.Any(x => x.Members.Contains(user) || x.Creator == user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {name}!");
                    }
                    else
                    {
                        teams.First(x => x.TeamName == name).Members.Add(user);
                    }

                    input = Console.ReadLine();
                }

                var finalTeam = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();
                StringBuilder output = new StringBuilder();

                foreach (var team in finalTeam)
                {
                    output.AppendLine(team.TeamName);
                    output.AppendLine("- " + team.Creator);
                    foreach (var item in team.Members.OrderBy(x => x))
                    {
                        output.AppendLine("-- " + item);
                    }
                    Console.WriteLine(output.ToString().TrimEnd());
                    output.Clear();
                }

                var disbandedOnes = teams
                    .Where(x => x.Members.Count == 0)
                    .OrderBy(x => x.TeamName)
                    .ToList();

                Console.WriteLine($"Teams to disband:");
                foreach (var team in disbandedOnes)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }

        class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }

            public List<string> Members;

            public Team(string teamName, string creator)
            {
                TeamName = teamName;
                Creator = creator;
                Members = new List<string>();
            }
        }
    }
}