using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //1. Write a test that returns true when the string is empty
        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //2. Write a test that returns true when the string has one bracket at each end
        [TestMethod]
        public void OneBracketAtEachEndReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //3. Returns true with two open brackets and two closed
        [TestMethod]
        public void TwoOpenAndClosedBracketReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        //4. Returns true with three open brackets and three closed
        [TestMethod]
        public void ThreeOpenAndClosedBracketReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[]]]"));
        }

        //5. Returns true with something in the string
        [TestMethod]
        public void ReturnTrueIfStringHasSomethingInIt()
        {
            Assert.IsNotNull(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //6. Returns true with 4 open and closed
        [TestMethod]
        public void FourOpenAndClosedReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[]]]]"));
        }

        //7. Write a test that returns false when string has two opposite facing brackets
        [TestMethod]
        public void TwoOppositeFacingBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        //8. Write test to return false when it has two open brackets
        [TestMethod]
        public void TwoOpenBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }

        //9. Write test to return false when it has two closed brackets
        [TestMethod]
        public void TwoClosedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        //10. Write test to return false when it has 2 backwards brackets
        [TestMethod]
        public void TwoBackwardsBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]][["));
        }

        //11. Write test to return false when it one open bracket
        [TestMethod]
        public void OneOpenBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //12. Write test to return false when it has two closed brackets
        [TestMethod]
        public void TwoClosedBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        


    }
}
