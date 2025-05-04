using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public struct Participant1
    {
        private string _name;
        private string _surname;
        private double _firstJump;
        private double _secondJump;
        public string Name { get { return _name; } }
        public string Surname { get { return _surname; } }
        public double FirstJump { get { return _firstJump; } }
        public double SecondJump { get { return _secondJump; } }
        public double BestJump { get { return Math.Max(_firstJump, _secondJump); } }
        public Participant1(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _firstJump = 0;
            _secondJump = 0;
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
        public static void Sort(Participant1[] array)
        {
            Array.Sort(array, (a, b) => b.BestJump.CompareTo(a.BestJump));
        }
        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {BestJump}");
        }
    }
}
