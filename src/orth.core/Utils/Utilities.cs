using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orth.Core.Utils
{
    public static class Utilities
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        
        /// <summary>
        /// Generates a random string of given <paramref name="size"/>
        /// </summary>
        /// <param name="size">The length of the string to generate</param>
        /// <returns></returns>
        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Parses a string into true or false. If the string cannot be parsed, it returns the default value
        /// </summary>
        /// <param name="value">The string to parse</param>
        /// <param name="defaultValue">The default value to use if the string was not able to be parsed</param>
        /// <returns></returns>
        public static bool ParseTrueFalse(string value, bool defaultValue = false)
        {
            bool retVal = defaultValue;

            if (!string.IsNullOrWhiteSpace(value))
            {
                switch (value.ToLowerInvariant())
                {
                    case "yes":
                    case "y":
                    case "true":
                    case "t":
                    case "on":
                    case "1":
                        retVal = true;
                        break;
                    case "no":
                    case "n":
                    case "false":
                    case "f":
                    case "off":
                    case "0":
                        retVal = false;
                        break;
                }
            }
            return retVal;
        }
    }
}
