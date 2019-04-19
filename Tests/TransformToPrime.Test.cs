using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransformToPrime;

namespace Tests {
    [TestClass]
    public class TransformToPrime_Test {
        [TestMethod]
        public void Test_MinimumNumber() {
            Assert.AreEqual(1, Solution.MinimumNumber(new int[] { 3, 1, 2 }));
            Assert.AreEqual(0, Solution.MinimumNumber(new int[] { 5, 2 }));
            Assert.AreEqual(0, Solution.MinimumNumber(new int[] { 1, 1, 1 }));
            Assert.AreEqual(5, Solution.MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
            Assert.AreEqual(2, Solution.MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
        }
    }
}
