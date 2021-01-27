using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Zad7
{
    class Student : ICloneable, IComparable<Student>, IPrintable<Student>
    {
        public static int ID_COUTER = 1;
        public const int SUBJECTS_NUMBER = 10;
        public const int NAME_LENGTH = 6;

        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }

        public Student(string name, int[] marks)
        {
            Id = ID_COUTER;
            ID_COUTER++;
            Name = name;
            Marks = marks;
        }

        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Marks = student.Marks;
        }

        public object Clone()
        {
            var clone = new Student(this);
            
            return clone;

        }

      

        public int CompareTo([AllowNull] Student other)
        {
            if (other == null)
                return 1;
            return Name.CompareTo(other.Name);
        }

        public void Print()
        {
            int i = 0;
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            foreach (int mark in Marks)
            {
                i++;
                Console.WriteLine("Mark Id:" + i + " | Value = " + mark + "\n");
            }
        }
    }
}
