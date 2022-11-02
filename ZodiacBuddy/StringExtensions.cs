using System.Globalization;

namespace ZodiacBuddy
{
    /// <summary>
    /// String Extesion class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Makes every first character of a word inside a string uppercase.
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>Capitalized Input String</returns>
        public static string ToTitleCase(this string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}