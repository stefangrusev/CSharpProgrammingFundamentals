using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();
            string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            while (command[0] != "Log out")
            {
                string username = command[1];
                if (command[0] == "New follower")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower());
                        followers[username].Likes = 0;
                        followers[username].Comments = 0;
                    }
                }
                else if (command[0] == "Like")
                {
                    int likesCount = int.Parse(command[2]);
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower());
                        followers[username].Likes = likesCount;
                        followers[username].Comments = 0;
                    }
                    else
                    {
                        followers[username].Likes += likesCount;
                    }
                }
                else if (command[0] == "Comment")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower());
                        followers[username].Likes = 0;
                        followers[username].Comments = 1;
                    }
                    else
                    {
                        followers[username].Comments += 1;
                    }
                }
                else if (command[0] == "Blocked")
                {
                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        followers.Remove(username);
                    }
                }
                command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value.Likes+follower.Value.Comments}");
            }
        }

        class Follower
        {
            public int Likes { get; set; }
            public int Comments { get; set; }
        }
    }
}
