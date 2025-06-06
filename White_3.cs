﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class White_3
    {
        public struct Student
        {
            private string _name;
            private string _surname;
            private int[] _marks;
            private int _skipped;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Skipped { get { return _skipped; } }
            public double AvgMark
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return 0.0;
                    double sum = 0.0;
                    foreach (var mark in _marks)
                    {
                        sum = sum + mark;
                    }
                    return sum/_marks.Length;
                }
            }
            public Student(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[0];
                _skipped = 0;
            }
            public void Lesson(int mark)
            {
                if (mark == 0)
                {
                    _skipped++;
                }
                else
                {
                    Array.Resize(ref _marks, _marks.Length+1);
                    _marks[_marks.Length-1] = mark;
                }
            }
            public static void SortBySkipped(Student[] array)
            {
                Array.Sort(array, (student1, student2) => student2.Skipped.CompareTo(student1.Skipped));
            }
            public void Print()
            {
                Console.WriteLine($"{Name},{Surname},AvgMark={AvgMark: F2},Skipped={Skipped}");
            }
        }
    }
}
