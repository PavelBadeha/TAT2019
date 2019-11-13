using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of students
    /// </summary>
    class Student:Person,IComparable
    {
        /// <summary>
        /// Array of student's marks
        /// </summary>
        [JsonProperty]
        public int[] Marks { get; private set; } = new int[5];

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Student() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of student</param>
        /// <param name="age">Age of student</param>
        /// <param name="marks">Array of student's marks</param>
        public Student(string name, int age, int[] marks) : base(name, age)
        {
            marks.CopyTo(Marks,0);
        }

        /// <summary>
        /// Class constructors 
        /// </summary>
        /// <param name="name">Name of student</param>
        /// <param name="age">Age of student</param>
        public  Student(string name,int age) : base(name, age) { }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the student.</returns>
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

        /// <summary>
        /// Method of interface IComparble
        /// </summary>
        /// <param name="student">Student that needed to compare with</param>
        /// <returns></returns>
        public int CompareTo(object student)
        {  
            return Marks.Average().CompareTo((student as Student).Marks.Average());
        }
    }
}
