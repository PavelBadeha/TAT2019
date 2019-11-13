using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    /// <summary>
    /// Class comparer, that compare student bu name
    /// </summary>
    class StudentComparerByName:IComparer<Student>
    {
        /// <summary>
        /// Method of comparation
        /// </summary>
        /// <param name="x">First student</param>
        /// <param name="y">Second student</param>
        /// <returns></returns>
        public int Compare(Student x,Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
