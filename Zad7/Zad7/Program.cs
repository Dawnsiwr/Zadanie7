using System;
using System.Collections.Generic;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Students = new Student[100];
            List<Student> StudentsCopy = new List<Student>();

            Utils Utils = new Utils();
            string _TempName;
            int[] _TempMarks;
            for (int i = 0; i < Students.Length; i++)
            {
                _TempName = Utils.GenerateName(Student.NAME_LENGTH);
                _TempMarks = Utils.GenerateMarks(Student.SUBJECTS_NUMBER);
                Students[i] = new Student(_TempName, _TempMarks);
            }

            for (int i = 0; i < Students.Length; i++)
            {
                StudentsCopy.Add((Student)Students[i].Clone());
                Students[i] = null;
            }

            StudentsCopy.Sort();

            foreach (Student s in StudentsCopy)
            {
                s.Print();
            }

        }
    }
}