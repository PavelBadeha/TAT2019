using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Student:Person
    {
        public int[] Marks { get; set; }= new int[5];

        public Student() { }

        public Student(string name, int age, int[] marks, int departmentId) : base(name, age, departmentId)
        {
            marks.CopyTo(Marks,0);
        }
        public  Student(string name,int age) : base(name, age) { }

        public Student(string name, int age, int[] marks) : base(name, age)
        {
            marks.CopyTo(Marks,0);
        }

        public override string ToString()
        {
            StringBuilder marks = new StringBuilder();

            foreach (var mark in Marks)
            {
                marks.Append(mark+",");
            }
            marks[marks.Length-1] = '.';

            return "Student\n" + base.ToString() +" Marks:" + marks;
        }
    }
}
