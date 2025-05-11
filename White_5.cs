using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class White_5
    {
        public struct Match
        {
            private int _goals;
            private int _misses;

            public Match(int goals, int misses)
            {
                _goals = goals;
                _misses = misses;
            }

            public int Goals
            {
                get { return _goals; }
            }

            public int Misses
            {
                get { return _misses; }
            }

            public int Difference
            {
                get { return _goals - _misses; }
            }

            public int Score
            {
                get
                {
                    if (_goals > _misses)
                        return 3;
                    if (_goals == _misses)
                        return 1;
                    if (_goals < _misses)
                        return 0;

                    return 0;
                }
            }

            public void Print()
            {
                Console.WriteLine($"Match: Goals={Goals}, Misses={Misses}, Difference={Difference}, Score={Score}");
            }
        }

        public struct Team
        {
            private string _name;
            private Match[] _matches;

            public string Name { get { return _name; } }
            public Match[] Matches { get { return _matches; } }
            public int TotalDifference
            {
                get
                {
                    if (_matches == null || _matches.Length == 0)
                    {
                        return 0;
                    }
                    int sum = 0;
                    foreach (Match match in Matches)
                    {
                        sum = sum + match.Difference;
                    }
                    return sum;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_matches==null || _matches.Length == 0) 
                    { 
                        return 0; 
                    }
                    int sum = 0;
                    foreach (Match match in Matches)
                    {
                        sum=sum+ match.Score;
                    }
                    return sum;
                }
            }
            public Team(string name)
            {
                _name = name;
                _matches = new Match[0];
            }
            public void PlayMatch(int goals, int misses)
            {
                Array.Resize(ref _matches, _matches.Length+1);
                _matches[_matches.Length-1] = new Match(goals, misses);
            }
            public static void SortTeams(Team[] teams)
            {
                Array.Sort(teams, (team1, team2) =>
                {
                    int cmp = team2.TotalScore.CompareTo(team1.TotalScore);
                    if (cmp != 0)
                    {
                        return cmp;
                    }
                    return team2.TotalDifference.CompareTo(team1.TotalDifference);
                });
            }
            public void Print()
            {
                Console.WriteLine($"{Name},{TotalDifference},{TotalScore}");
            }
        }
    }
}






    

