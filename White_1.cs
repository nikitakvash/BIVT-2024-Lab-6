using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public struct Participant
    {
        private string _surname;
        private string _club;
        private double _firstJump;
        private double _secondJump;

        public string Surname { get { return _surname; } }
        public string Club { get { return _club; } }
        public double FirstJump { get { return _firstJump; } }
        public double SecondJump { get { return _secondJump; } }
        public double JumpSum { get { return _firstJump + _secondJump; } }

        public Participant(string surname, string club)
        {
            _surname = surname;
            _club = club;
            _firstJump = 0.0;
            _secondJump = 0.0;
        }

        public void Jump(double result)
        {
            if (_firstJump == 0)
            {
                _firstJump = result;
            }
            else if (_secondJump == 0)
            {
                _secondJump = result;
            }
        }
        public static void Sort(Participant[] array)
        {
            Array.Sort(array, (a,b) => b.JumpSum.CompareTo(a.JumpSum));
        }
        public void Print()
        {
            Console.WriteLine($"{Surname} {Club} {JumpSum}");
        }
    }    
}
