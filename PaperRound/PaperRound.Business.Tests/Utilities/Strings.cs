using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperRound.Business.Tests.Utilities
{
    /// <summary>
    /// Test for utilities pertaining to strings and their manipulation
    /// </summary>
    [TestClass]
    public class Strings
    {
        /// <summary>
        /// Determines whether [is valid false].
        /// </summary>
        [TestMethod]
        public void IsValidFalse()
        {
            Assert.IsFalse(Business.Utilities.Strings.IsValidStreet(Constants.Strings.StreetNumbers));
        }

        /// <summary>
        /// Determines whether [is valid true].
        /// </summary>
        [TestMethod]
        public void IsValidTrue()
        {
            Assert.IsTrue(Business.Utilities.Strings.IsValidStreet(Constants.Strings.StreetNumbers));
        }
    }
}
