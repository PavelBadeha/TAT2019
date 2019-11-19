using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_3
{
    /// <summary>
    /// Class that translates a string
    /// </summary>
    public class StringTranslator
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

        /// <summary>
        /// Method that translates a string
        /// </summary>
        /// <param name="str">string that needed to translate</param>
        /// <returns>translated string</returns>
        public string Translate(string str)
        {
            if (str == string.Empty)
            {
                return str;
            }

            str = str.ToUpper();

            if (str[0] < 'Z' && str[0] > 'A')  
            {
                return TranslateEngToRus(str);
            }
            else
            {
                return TranslateRusToEng(str);
            }
        }

        /// <summary>
        /// Method that translates english string to russian
        /// </summary>
        /// <param name="str">String that needed to translate</param>
        /// <returns>translated string</returns>
        private string TranslateEngToRus(string str)
        {
            ValidationCheck(str);
            StringBuilder buff = new StringBuilder();

            foreach (var letter in str)
            {
                buff.Append(_englishToRussianLetters[letter.ToString()]);
            }

            return buff.ToString();
        }

        /// <summary>
        /// Method that translates russian string ti english 
        /// </summary>
        /// <param name="str">String that needed to translate</param>
        /// <returns>translated string</returns>
        private string TranslateRusToEng(string str)
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
        private void ValidationCheck(string str)
        {
            if (str.Any(x => x >= 'A' && x < 'Z' && (x > 1039 && x < 1072)) || 
                str.Any(x => x < 'A' && x > 'Z' || (x < 1040 && x > 1071)))
            {
                throw new FormatException("Invalid string format!");
            }
        }
    }
}
