using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public struct Participant2
    {
        private string _name;
        private string _surname;
        private double[] _scores;
        private int _scoreCount;

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
                for (int i = 0; i < _scoreCount; i++)
                {
                    sum+= _scores[i];
                }
                return sum;
            }       
        }
        public Participant2(string name,string surname)
        {
            _name=name;
            _surname=surname;
            _scores = new double[100];
            _scoreCount = 0;
        }
        public void PlayMatch(double result)
        {
            if (_scoreCount < _scores.Length)
            {
                _scores[_scoreCount]=result;
                _scoreCount++;
            }
        }
        public static void Sort(Participant2[] array)
        {
            Array.Sort(array, (player1,player2) => player2.TotalScore.CompareTo(player1.TotalScore));
        }
        public void Print()
        {
            Console.WriteLine($"{Name},{Surname},TotalScore={TotalScore}");
        }

    }
}
