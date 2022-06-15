using GestForm;
using System;

namespace GestformUnitTests
{
    static class TestHelper
    {
        /// <summary>
        /// Verify if the value is in the GestForm format or an integer between -1000 and 1000.
        /// </summary>
        /// <param name="value">value</param>
        public static bool IsValueValid(this string value)
        {
            return IsValueInGestFormFormat(value) || IsValidInteger(value);
        }

        /// <summary>
        /// Verify if the value is equal to Geste, Gestform or Forme.
        /// </summary>
        /// <param name="value">value</param>
        private static bool IsValueInGestFormFormat(string value)
        {
            return string.Equals(value, Constants.Geste, StringComparison.OrdinalIgnoreCase)
                            || string.Equals(value, Constants.Gestform, StringComparison.OrdinalIgnoreCase)
                            || string.Equals(value, Constants.Forme, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Verify if the value is of type integer and between -1000 and 1000.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool IsValidInteger(string value)
        {
            bool parseSucceed = int.TryParse(value, out int integer);
            return parseSucceed && (integer >= Constants.MinValue || integer <= Constants.MaxValue);
        }
    }
}
