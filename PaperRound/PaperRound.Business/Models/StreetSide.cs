using System.Collections.Generic;

namespace PaperRound.Business.Models
{
    /// <summary>
    /// Model representing one side of a street
    /// </summary>
    public class StreetSide
    {
        /// <summary>
        /// Gets or sets the street numbers.
        /// </summary>
        /// <value>
        /// The street numbers on this side of the street.
        /// </value>
        public List<int> StreetNumbers { get; set; } 
    }
}
