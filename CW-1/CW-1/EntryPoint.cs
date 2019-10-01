using System;
using System.Collections.Generic;

namespace CW_1
{
    /// <summary>
    /// Main class of the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {
            Point A = new Point(0,0);
            Point B = new Point(2, 4);
            Point C = new Point(4, 0);

            Point A1= new Point(1, 0);
            Point B1= new Point(2, 4);
            Point C1= new Point(4, 0);

            List<Triangle> triangles = new List<Triangle>() {new Triangle(A, B, C)
                                                            ,new Triangle(A1,B1,C1)
                                                            ,new Triangle(B,A,C)};

           Console.WriteLine(Triangle.IsThereTwoIdenticalTriangles(triangles)); 

        }
    }
}
