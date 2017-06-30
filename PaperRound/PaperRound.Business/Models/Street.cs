using System.Collections.Generic;

namespace PaperRound.Business.Models
{
    /// <summary>
    /// Mode representing the street
    /// </summary>
    public class Street
    {
        /// <summary>
        /// Gets or sets the crosses.
        /// </summary>
        /// <value>
        /// The number of times the paperboy crosses the street.
        /// </value>
        public int Crosses { get; set; }

        /// <summary>
        /// Gets or sets the houses.
        /// </summary>
        /// <value>
        /// A strongly typed list of houses to make mvp.
        /// </value>
        public List<House> Houses { get; set; } 

        /// <summary>
        /// Gets or sets the north.
        /// </summary>
        /// <value>
        /// The north side of the street.  The odd numbers
        /// </value>
        public StreetSide North { get; set; }

        /// <summary>
        /// Gets or sets the south.
        /// </summary>
        /// <value>
        /// The south side of the street. The even numbers
        /// .
        /// </value>
        public StreetSide South { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>
        /// The sequence of house numbers.
        /// </value>
        public string Sequence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Street"/> is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if valid; otherwise, <c>false</c>.
        /// </value>
        public bool Valid { get; set; }
    }
}
