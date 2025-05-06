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
            private int _matchCount;
            public string Name { get { return _name; } }
            public Match[] Matches { get { return _matches; } }
            public int TotalDiffirience
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < _matchCount; i++)
                    {
                        sum += _matches[i].Difference;
                    }
                    return sum;
                }
            }
            public int TotalScore
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < _matchCount; i++)
                    {
                        sum = sum + _matches[i].Score;
                    }
                    return sum;
                }
            }
            public Team(string name)
            {
                _name = name;
                _matches = new Match[100];
                _matchCount = 0;
            }
            public void PlayMatch(int goals, int misses)
            {
                if (_matchCount < _matches.Length)
                {
                    _matches[_matchCount] = new Match(goals, misses);
                    _matchCount++;
                }
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
                    return team2.TotalDiffirience.CompareTo(team1.TotalDiffirience);
                });
            }
            public void Print()
            {
                Console.WriteLine($"{Name},{TotalDiffirience},{TotalScore}");
            }
        }
    }
}


    




    

