using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeiiGrei;
using IsPalindrom;

namespace IsPalindromeTest
{
    public class IBANPalindromeTests
    {
        public IBAN Iban { get; set; }

        [TestClass]
        public class WhenIBANIsPalindrome : IBANPalindromeTests
        {
            [TestInitialize]
            public void TestInitialize()
            {
                this.Iban = new IBAN("RO38PORL1234567887654321");
            }
            [TestMethod]
            public void IsPalindrome()
            {
                bool result = this.Iban.IsPalindrom();

                Assert.IsTrue(result);
            }
        }



        [TestClass]
        public class WhenIBANIsNotPalindrome : IBANPalindromeTests
        {
            [TestInitialize]
            public void TestInitialize()
            {
                this.Iban = new IBAN("RO38PORL1111111122222222");
            }
            [TestMethod]
            public void IsPalindrome()
            {
                bool result = this.Iban.IsPalindrom();

                Assert.IsFalse(result);
            }
        }
    }

}
