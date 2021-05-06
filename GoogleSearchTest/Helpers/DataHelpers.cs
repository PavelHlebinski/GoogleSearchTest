using System;
using System.Globalization;

namespace GoogleSearchTest.Helpers
{
    public class DataHelpers
    {
        public static bool IsDataFormatCorrect(string data)
        {
            string[] formats = { "mm/dd/yyyy" };
            if (DateTime.TryParseExact(data, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDataTimeFormatCorrect(string data)
        {
            string[] formats = { "MMMM d, yyyy hh:mm tt" };
            if (DateTime.TryParseExact(data, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
