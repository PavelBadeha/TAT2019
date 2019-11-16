using System;
using System.Linq;

namespace Dev_2
{
    class StringAnalyzer
    {
        /// <summary>
        /// String that need to analyze
        /// </summary>
        private string str = string.Empty;

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public StringAnalyzer()
        {
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
        }

        /// <summary>
        /// Returns the maximum number of unequal consecutive characters in a string
        /// </summary>
        public int MaxOfNotIdenticalConsecutiveSymbols()
        {
            int result = 1;
            int buff = 1;

            for (int i = 0; i < str.Length; i++) 
            {
                if( i < str.Length - 1 && str[i + 1] != str[i])
                {
                    buff++;
                }
                else
                {
                    if (buff > result)
                    {
                        result = buff;
                    }
                    buff = 1;
                }
            }
            if (str == string.Empty)
            {
                return 0;
            }
            return result;                   
        }

        /// <summary>
        /// Returns the maximum number of identical consecutive digits in a string
        /// </summary>
        public int MaxOfIdenticalConsecutiveDigits()
        {
            int result = 1;
            int buff = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1 && str[i + 1] == str[i] && (str[i] > 47 && str[i] < 58))
                {
                    buff++;
                }
                else
                {
                    if (buff > result)
                    {
                        result = buff;
                    }
                    buff = 1;
                }
            }

            if (!str.Any(x => x > 47 && x < 58))
            {
                return 0;
            }
            return result;
        }

        /// <summary>
        /// Returns the maximum number of identical consecutive Latin characters in a string
        /// </summary>
        public int MaxOfIdenticalConsecutiveLatinSymbols()
        {
            int result = 1;
            int buff = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if ((i < str.Length - 1 && str[i + 1] == str[i])
                    && ( str[i] > 64 && str[i] < 91 || (str[i] > 96 && str[i] < 123)))
                {
                    buff++;
                }
                else
                {
                    if (buff > result)
                    {
                        result = buff;
                    }
                    buff = 1;
                }
            }

            if (!str.Any(x => x > 64 && x < 91 || (x > 96 && x < 123)))
            {
                return 0;
            }
            return result;
        }
    }
}
