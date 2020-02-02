using System.Text.RegularExpressions;

namespace RegexManager
{
    public class RegexUtil
    {
        /// <summary>
        /// 半角数字
        /// </summary>
        private const string HALF_NUMBER = @"^[0-9]+$";

        /// <summary>
        /// 半角英字
        /// </summary>
        private const string HALF_ALPHABET = @"^[a-zA-Z]+$";


        public bool IsHalfNumber(string input)
        {
            var result = Regex.IsMatch(input, HALF_NUMBER);
            return result;
        }

        public bool IsHalfAlphabet(string input)
        {
            var result = Regex.IsMatch(input, HALF_ALPHABET);
            return result;
        }
    }
}