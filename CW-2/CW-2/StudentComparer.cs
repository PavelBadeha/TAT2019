﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class StudentComparerByName:IComparer<Student>
    {
        public int Compare(Student x,Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
