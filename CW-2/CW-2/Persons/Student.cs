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
        public  Student(string name,int age) : base(name, age) { }

        public Student(string name, int age, int[] marks) : base(name, age)
        {
            this.Marks.CopyTo(marks, 0);
        }
    }
}
