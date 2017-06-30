using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperRound.Business.Tests.Utilities
{
    /// <summary>
    /// Tests of the integer utliites
    /// </summary>
    [TestClass]
    public class Integers
    {
        /// <summary>
        /// Determines whether [is odd true].
        /// </summary>
        [TestMethod]
        public void IsOddTrue()
        {
            Assert.IsTrue(Business.Utilities.Integers.IsOdd(1));
        }

        /// <summary>
        /// Determines whether [is odd false].
        /// </summary>
        [TestMethod]
        public void IsOddFalse()
        {
            Assert.IsFalse(Business.Utilities.Integers.IsOdd(2));
        }
    }
}
