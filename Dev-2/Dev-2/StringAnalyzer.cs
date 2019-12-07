using System.Linq;
using System;

namespace Dev_2
{
    public class StringAnalyzer
    {
        private int MaxConsecutiveSymbols(string str,Func<string,int,bool> func)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = 1;
            int maxCount = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (func(str,i))
                {
                    maxCount++;
                }
                else
                {
                    if (maxCount > result)
                    {
                        result = maxCount;
                    }
                    maxCount = 1;
                }
            }
            return result;
        }
        /// <summary>
        /// Returns the maximum number of unequal consecutive characters in a string
        /// </summary>
        public int MaxOfNotIdenticalConsecutiveSymbols(string str)
        {
            return MaxConsecutiveSymbols(str, (x, i) => i < x.Length - 1 && (x[i + 1] != x[i]));           
        }

        /// <summary>
        /// Returns the maximum number of identical consecutive digits in a string
        /// </summary>
        public int MaxOfIdenticalConsecutiveDigits(string str)
        {
            if (!str.Any(x => x > 47 && x < 58))
            {
                return 0;
            }

            return MaxConsecutiveSymbols(str, (x, i) => i < x.Length - 1 && (x[i] > 47 && x[i] < 58) && (x[i + 1] == x[i]));               
        }

        /// <summary>
        /// Returns the maximum number of identical consecutive Latin characters in a string
        /// </summary>
        public int MaxOfIdenticalConsecutiveLatinSymbols(string str)
        { 
            if (!str.Any(x => x > 64 && x < 91 || (x > 96 && x < 123)))
            {
                return 0;
            }
            return MaxConsecutiveSymbols(str, (x, i) => i < x.Length - 1 && (x[i + 1] == x[i]) &&
                                                        (x[i] > 64 && x[i] < 91 || (x[i] > 96 && x[i] < 123)));
        }
    }
}