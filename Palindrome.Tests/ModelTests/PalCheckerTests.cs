using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalChecker;

namespace PalChecker.Tests
{
  [TestClass]
  public class PalindromesTests
  {
    [TestMethod]
    public void IsPalindrome_HasString_String()
    {
      string testString = "test";
      PalChecker testPal = new PalChecker(testString);
      Assert.AreEqual(testString, testPal.myString);
    }
  }
}

//provide word and return true based on palindrom or not
