using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRound.Business.Models
{
    /// <summary>
    /// Model for each unit on the street
    /// </summary>
    public class House
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The house number.
        /// </value>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>
        /// The positon of the house in a west to east sequence.
        /// </value>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is even.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is even; otherwise, <c>false</c>.
        /// Purely included to ascertain when the sequence changes side of the street
        /// </value>
        public bool IsEven { get; set; }
    }
}
