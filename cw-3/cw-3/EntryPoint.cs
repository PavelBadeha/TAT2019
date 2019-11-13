using System;

namespace cw_3
{
    /// <summary>
    /// Entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method 
        /// </summary>
        static void Main()
        {
            Manager manager = new Manager();
            int?[] values = new int?[] { 1,null,null,null,2,null, null, null, 3 };
            Matrix<int?> matrix = new Matrix<int?>(3, values);

            matrix.OnChanged += manager.DisplayChanges;
            Console.WriteLine(matrix.IsDiagonal());
            matrix[0, 0] = 3;
            Console.WriteLine(matrix[0, 0]); 
        }
    }
}
