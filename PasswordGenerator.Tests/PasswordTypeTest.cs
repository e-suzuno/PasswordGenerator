using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordGenerator.Domain.ValueObjects;

namespace PasswordGenerator.Tests
{
    [TestClass]
    public class PasswordTypeTest
    {
        [TestMethod]
        public void 同一値チェック()
        {

            Assert.IsTrue(new PasswordType(PasswordType.AlphabetValue) == PasswordType.Alphabet);
            Assert.IsTrue(new PasswordType(PasswordType.NumberValue) == PasswordType.Number);

        }
        public void 不一致チェック()
        {

            Assert.IsTrue(new PasswordType(PasswordType.AlphabetValue) == PasswordType.Alphabet);
            Assert.IsTrue(new PasswordType(PasswordType.NumberValue) == PasswordType.Number);

        }
    }
}
