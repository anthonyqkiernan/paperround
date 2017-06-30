using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRound.Business.Utilities
{
    /// <summary>
    /// Utilities pertaining to integers and their manipulation
    /// </summary>
    public class Integers
    {
        /// <summary>
        /// Determines whether the specified value is odd.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is odd; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOdd(int value)
        {
            return (value % 2 != 0);
        }
    }
}
