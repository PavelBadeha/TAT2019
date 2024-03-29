﻿namespace Dev_0
{   
    /// <summary>
    /// The class that contains a method which returns maximum number of repeated consecutive letters
    /// </summary>
    class CounterMaximumNumberRepeatingLetters
    {
        /// <summary>
        /// <param name="_str">String field for which counts will be performed</param>
        /// </summary>
        private string _str = string.Empty;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="str">String for which counts will be performed</param>
        public CounterMaximumNumberRepeatingLetters (string str)
        {
            _str = str;
        }

        /// <summary>
        /// The method returns maximum number of repeated consecutive letters
        /// </summary>
        public  int Count()
        {
            int count = 1;
            int max = 0;
            for (int i = 0; i < _str.Length; i++)
            {
                if (i + 1 < _str.Length && _str[i].Equals(_str[i + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (max < count)
                {
                    max = count;
                }
            }
            return max;
        }
    }
}
