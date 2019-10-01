using System;

namespace CW_1
{
    /// <summary>
    /// Class Point
    /// </summary>
    class Point
    {
        /// <summary>
        /// Point X
        /// </summary>
        public double pointX { get; set; }
        /// <summary>
        /// Point Y
        /// </summary>
        public double pointY { get; set; }

        /// <summary>
        /// Constructor of the class 
        /// </summary>
        /// <param name="pointX">Point X</param>
        /// <param name="pointY">Point Y</param>
        public Point(double pointX, double pointY)
        {
            this.pointX = pointX;
            this.pointY = pointY;
        }

        /// <summary>
        /// Method that calculate the distance between two points
        /// </summary>
        /// <param name="A">Second point</param>
        /// <returns>The distance</returns>
        public double GetDistance(Point A)
        {
            return Math.Pow(Math.Pow(pointX - A.pointX, 2) + Math.Pow(pointY - A.pointY, 2), 0.5);
        }
    }
}
