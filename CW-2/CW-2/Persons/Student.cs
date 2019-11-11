using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace CW_2
{
    class Student:Person,IComparable
    {
        [JsonProperty]
        public int[] Marks { get; private set; } = new int[5];

        public Student() { }

        public Student(string name, int age, int[] marks) : base(name, age)
        {
            marks.CopyTo(Marks,0);
        }
        public  Student(string name,int age) : base(name, age) { }

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
        public int CompareTo(object student)
        {  
            return Marks.Average().CompareTo((student as Student).Marks.Average());
        }
    }
}
