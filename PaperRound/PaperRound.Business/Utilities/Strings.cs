using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaperRound.Business.Utilities
{
    /// <summary>
    /// Utilities pertaining to the array of street numbers and their manipulation and validation
    /// </summary>
    public class Strings
    {
        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <param name="street">The street array</param>
        /// <returns>
        ///   <c>true</c> if the specified street array is valid; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidStreet(string street)
        {
            //Currently only tests for numbers and spaces
            // TODO: Check for sequential numbers when split to odd and even
            var regex = new Regex(@"^[0-9 ]*$");

            var match = regex.Match(street);

            return match.Success;
        }
    }
}
