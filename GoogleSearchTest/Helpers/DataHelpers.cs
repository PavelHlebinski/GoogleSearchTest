using System;
using System.Globalization;

namespace GoogleSearchTest.Helpers
{
    public class DataHelpers
    {
        public static bool IsDataFormatCorrect(string data)
        {
            string[] format = { "mm/dd/yyyy" };
            if (DateTime.TryParseExact(data, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
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
            string[] format = { "MMMM d, yyyy hh:mm tt" };
            if (DateTime.TryParseExact(data, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
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
