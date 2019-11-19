namespace Dev_1
{
    /// <summary>
    /// Struct of cell point on chess board
    /// </summary>
    struct ChessCell
    {
        public char Column { get; }
        public int Row { get; }

        /// <summary>
        /// Struct constructor
        /// </summary>
        /// <param name="column">Char of column</param>
        /// <param name="row">Number of row</param>
        public ChessCell(char column,int row)
        {
            if (column > 96) 
            {
                Column = (char)(column - 32);
            }
            else
            {
                Column = column;
            }
            Row = row;
        }
    }
}
