using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_1
{
    /// <summary>
    /// Class triangle 
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// List of triangle tops 
        /// </summary>
        public List<Point> top = new List<Point>();

        /// <summary>
        /// List of side values
        /// </summary>
        public List<double> sides = new List<double>();

        /// <summary>
        /// Constructor without params
        /// </summary>
        public Triangle() { }

        /// <summary>
        /// Constructor with params of the three points
        /// </summary>
        /// <param name="A">Point A</param>
        /// <param name="B">Point B</param>
        /// <param name="C">Point C</param>
        public Triangle(Point A, Point B, Point C)
        {
            top.Add(A);
            top.Add(B);
            top.Add(C);
            InitializationSides();
        }

        /// <summary>
        /// Constructor with param of the list of points
        /// </summary>
        /// <param name="top">list of points</param>
        public Triangle(List<Point> top)
        {
            this.top.Concat(top);
            InitializationSides();
        }

        /// <summary>
        /// Method that overrides the method "Equals" 
        /// </summary>
        /// <param name="obj">Triangle object to compare with</param>
        /// <returns>True if is equals and False if isn't equals </returns>
        public override bool Equals(object obj)
        {
            Triangle temp;
            if (obj is Triangle)
            {
                temp = (Triangle)obj;
            }
            else
            {
                temp= new Triangle();
            }
            
            for (int i = 0; i < 3; i++)
            {
                if (Math.Abs(sides[i] - temp.sides[i]) > Double.Epsilon)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Method display sides of the triangle 
        /// </summary>
        public void DisplaySides()
        {
            foreach (var side in sides)
            {
                Console.WriteLine(side);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method that checks if there are at least two identical triangles in the list
        /// </summary>
        /// <param name="triangles">List of triangles</param>
        /// <returns>True if is there two identical triangles and False if isn't there two identical triangles</returns>
        public static bool IsThereTwoIdenticalTriangles(List<Triangle> triangles)
        {
            bool check = false;
            for (int i = 0; i < triangles.Count; i++)
            {
                for (int j = i + 1; j < triangles.Count; j++)
                {
                    if (triangles[i].Equals(triangles[j]))
                    {
                        check = true;
                        break;
                    }
                }
            }

            return check;
        }
        /// <summary>
        /// Method that initializes the sides of a triangle by points
        /// </summary>
        private void InitializationSides()
        {
            for (int i = 0; i < 3; i++)
            {
                sides.Add(top[i].GetDistance(top[(i+1)%3]));
            }
            sides.Sort();
        }
}
}
