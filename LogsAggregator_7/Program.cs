using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var IPs = int.Parse(Console.ReadLine());
            var usersSessions = new Dictionary<string, int>();
            var usersIPs = new Dictionary<string, SortedSet<string>>();

            for (int i = 0; i < IPs; i++)
            {
                var currentUser = Console.ReadLine().Split(' ');
                var currentSession = int.Parse(currentUser[2]);
                var currentIP = currentUser[0];

                if (!usersSessions.ContainsKey(currentUser[1]))
                {
                    usersSessions.Add(currentUser[1], currentSession);
                }
                else
                {
                    usersSessions[currentUser[1]] += currentSession;
                }
                if (!usersIPs.ContainsKey(currentUser[1]))
                {
                    usersIPs.Add(currentUser[1], new SortedSet<string>() {currentIP});
                }
                else
                {
                    usersIPs[currentUser[1]].Add(currentIP);
                }

            }

            foreach (var u in usersSessions.OrderBy(k => k.Key))
            {
                var list = usersIPs[u.Key].ToList();
                string what = string.Join(", ", list.ToArray());
                Console.WriteLine($"{u.Key}: {u.Value} [{what}]");
            }
        }
    }
}
