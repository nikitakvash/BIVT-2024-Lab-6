using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public struct Student
    {
        private string _name;
        private string _surname;
        private int[] _marks;
        private int _marksCount;
        private int _skipped;

        public string Name { get { return _name; } }
        public string Surname { get { return _surname; } }    
        public int Skipped { get { return _skipped; } }
        public double AvgMark
        {
            get
            {
                if( _marks == null || _marksCount == null )
                {
                    return 0.0;
                }
                var sum= 0.0;
                for (int i=0; i< _marksCount; i++) 
                { 
                    sum += _marks[i]; 
                }
                return sum / _marksCount;
            }
        }
        public Student(string name,string surname)
        {
            _name = name;
            _surname = surname;
            _marks = new int[100];
            _marksCount = 0;
            _skipped = 0;
        }
        public void Lesson(int mark)
        {
            if (mark==0)
            {
                _skipped++;
            }
            else
            {
                if (_marksCount<100)
                {
                    _marks[_marksCount] = mark;
                    _marksCount++;
                }
            }
        }
        public static void SortBySkipped(Student[] array)
        {
            Array.Sort(array, (student1, student2) => student2.Skipped.CompareTo(student1.Skipped));
        }
        public void Print()
        {
            Console.WriteLine($"{Name},{Surname},AvgMark={AvgMark : F2},Skipped={Skipped}");
        }
    }
}
