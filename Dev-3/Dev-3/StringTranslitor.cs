using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev_3
{
    /// <summary>
    /// Class that translites a string
    /// </summary>
    public class StringTranslitor
    {
        private Dictionary<string,string> _russianToEnglishLetters = new Dictionary<string, string>
        {
            { "А","A" },{"Б","B"},{"В","V" },{"Г","G" },{"Д","D" },{"Е","E" },{"Ё","YO" },{"Ж","ZH" },
            { "З","Z" },{"И","I" },{"Й","Y" },{"К","K" },{"Л","L" },{"М","M" },{"Н","N"},{"О","O" },{"П","P" },
            { "Р","R"},{"С","S" },{"Т","T" },{"У","U" },{"Ф","F" },{"Х","KH" },{"Ц","TS" },{"Ч","CH" },
            { "Ш","SH" },{"Щ","SCH" },{"Ъ",string.Empty },{"Ы","Y"},{"Ь",string.Empty},{"Э","E" },
            { "Ю","YU" },{"Я","YA" }
        };

        private Dictionary<string, string> _englishToRussianLetters = new Dictionary<string, string>
        {
            { "A","А" },{"B","Б"},{"C","Ц" },{"D","Д" },{"E","Е" },{"F","Ф" },{"G","Г" },{"H","Х" },
            { "I","И" },{"J","Ж" },{"K","К" },{"L","Л" },{"M","М" },{"N","Н" },{"O","О"},{"P","П" },{"Q","КУ" },
            { "R","Р"},{"S","С" },{"T","Т" },{"U","У" },{"V","В" },{"W","В" },{"X","КС" },{"Y","У" },
            { "Z","З" }
        };

        private Dictionary<string, string> _englishSpecialToRussianLetters = new Dictionary<string, string>
        {
            {"YO","Ё"},{"ZH","Ж"},{"KH","Х"},{"TS","Ц"},{"CH","Ч"},{"SH","Ш"},{"SCH","СК" },
            { "YU","Ю" },{"YA","Я"},{"OO","У"}
        };

        /// <summary>
        /// Method that translites a string
        /// </summary>
        /// <param name="str">string that needed to translite</param>
        /// <returns>translited string</returns>
        public string Translite(string str)
        {        
            ValidationCheck(str);
            str = str.ToUpper();

            if (str[0] <= 'Z' && str[0] >= 'A')  
            {
                return TransliteEngToRus(str);
            }
            else
            {
                return TransliteRusToEng(str);
            }
        }

        /// <summary>
        /// Method that translites english string to russian
        /// </summary>
        /// <param name="str">String that needed to translite</param>
        /// <returns>translited string</returns>
        private string TransliteEngToRus(string str)
        {
            StringBuilder buff = new StringBuilder();

            for (int i = 0; i < str.Length; i++) 
            {
                if (i < str.Length - 3 && _englishSpecialToRussianLetters.ContainsKey(str.Substring(i,3)))
                {
                    buff.Append(_englishSpecialToRussianLetters[str.Substring(i, 3)]);
                    i += 2;
                }
                else if (i < str.Length - 2 && _englishSpecialToRussianLetters.ContainsKey(str.Substring(i, 2)) ) 
                {
                    buff.Append(_englishSpecialToRussianLetters[str.Substring(i, 2)]);
                    i += 1;
                }
                else
                {
                    buff.Append(_englishToRussianLetters[str[i].ToString()]);
                }             
            }

            return buff.ToString();
        }
           

        /// <summary>
        /// Method that translites russian string to english 
        /// </summary>
        /// <param name="str">String that needed to translite</param>
        /// <returns>translited string</returns>
        private string TransliteRusToEng(string str)
        {
            StringBuilder buff = new StringBuilder();

            foreach(var letter in str)
            {
                buff.Append(_russianToEnglishLetters[letter.ToString()]);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Method that check validation
        /// </summary>
        /// <param name="str">String that needed to check</param>
        /// FormatException("Invalid string format!"), exception of invalid string format
        public void ValidationCheck(string str)
        {
            if(string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str) || str.Contains(" "))
            {
                throw new FormatException("Invalid string format!");
            }
            str = str.ToUpper();

            if (str.Any(x => x >= 'A' && x <= 'Z') && str.Any(x => x >='А' && x <='Я') ||
               (str.Any(x => x < 'A' || x > 'Z') && str.Any(x => x < 'А' || x >'Я')))
            {
                throw new FormatException("Invalid string format!");
            }
        }
    }
}

