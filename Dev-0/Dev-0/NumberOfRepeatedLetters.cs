
namespace Dev_0
{   /// <summary>
    /// The class that contains a method which returns maximum number of repeated consecutive letters
    /// </summary>
    class NumberOfRepeatedLetters
    {
        /// <summary>
        /// The method returns maximum number of repeated consecutive letters
        /// </summary>
        public static int Calculate(string str)
        {
            int count = 1;
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 1 < str.Length && str[i].Equals(str[i + 1]))
                {
                    count++;
                }
                else
                    count = 1;
                if (max < count)
                    max = count;
            }
            return max;
        }
    }
}
