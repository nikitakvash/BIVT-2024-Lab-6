using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class White_4
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _scores;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public double[] Scores { get { return _scores; } }
            public double TotalScore
            {
                get
                {
                    if (_scores == null)
                    {
                        return 0.0;
                    }
                    var sum = 0.0;
                    foreach (var score in _scores)
                    {
                        sum += score;
                    }
                    return sum;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _scores = new double[0];
            }
            public void PlayMatch(double result)
            {
                Array.Resize(ref _scores, _scores.Length+1);
                _scores[_scores.Length-1] = result;
            }
            public static void Sort(Participant[] array)
            {
                Array.Sort(array, (player1, player2) => player2.TotalScore.CompareTo(player1.TotalScore));
            }
            public void Print()
            {
                Console.WriteLine($"{Name},{Surname},TotalScore={TotalScore}");
            }

        }
    }
}
