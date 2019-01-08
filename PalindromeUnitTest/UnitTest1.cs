using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("Deleveled"));
            Assert.IsTrue(Palindrome.IsPalindrome("non"));
            Assert.IsTrue(Palindrome.IsPalindrome("Racecar"));
            Assert.IsTrue(Palindrome.IsPalindrome("Kayak"));
            Assert.IsTrue(Palindrome.IsPalindrome("Madam"));
            Assert.IsTrue(Palindrome.IsPalindrome("Level"));
            Assert.IsTrue(Palindrome.IsPalindrome("Civic"));
            Assert.IsTrue(Palindrome.IsPalindrome("Noon"));
            Assert.IsTrue(Palindrome.IsPalindrome("Mom"));
            Assert.IsTrue(Palindrome.IsPalindrome("Rotator"));
            Assert.IsTrue(Palindrome.IsPalindrome("Don't nod"));
            Assert.IsTrue(Palindrome.IsPalindrome("I did, did I"));            
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("Boo Hoo"));
            Assert.IsFalse(Palindrome.IsPalindrome("This is a test"));
            Assert.IsFalse(Palindrome.IsPalindrome("Racefar"));
            Assert.IsFalse(Palindrome.IsPalindrome("Racca"));
        }
    }
}
