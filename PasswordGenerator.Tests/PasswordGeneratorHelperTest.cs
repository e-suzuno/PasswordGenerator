using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Domain.Helpers;
using PasswordGenerator.Domain.ValueObjects;
using System;
using System.Text.RegularExpressions;

namespace PasswordGenerator.Tests
{
    [TestClass]
    public class PasswordGeneratorHelperTest
    {


        [TestMethod]
        public void alphabetのみのPassword生成()
        {


            PasswordType[] types = new []{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(10, types);
            var hasAlphabet = new Regex(@"[A-Za-z]+");
            Assert.IsTrue(hasAlphabet.IsMatch(password));

            PasswordType[] types2 = new[]{
                PasswordType.Number
            };
            string password2 = PasswordGeneratorHelper.Create(10, types2);
            Assert.IsTrue(!hasAlphabet.IsMatch(password2));
        }



        [TestMethod]
        public void 数値のみのPassword生成()
        {


            PasswordType[] types = new[]{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(10, types);

            var hasNumber = new Regex(@"[0-9]+");


            Assert.IsTrue(hasNumber.IsMatch(password));



            PasswordType[] types2 = new[]{
                PasswordType.Alphabet
            };
            string password2 = PasswordGeneratorHelper.Create(10, types2);

            Assert.IsTrue(!hasNumber.IsMatch(password2));


        }


        [TestMethod]
        public void 数値とalphabetのPassword生成()
        {


            PasswordType[] types = new[]{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(10, types);

            var hasAlphabet = new Regex(@"[A-Za-z]+");
            var hasNumber = new Regex(@"[0-9]+");


            Assert.IsTrue(hasNumber.IsMatch(password));
            Assert.IsTrue(hasAlphabet.IsMatch(password));


        }

        [TestMethod]
        public void _８文字のPassword生成()
        {

            PasswordType[] types = new[]{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(8, types);
            Assert.AreEqual(8 , password.Length);

        }

        [TestMethod]
        public void _１０文字のPassword生成()
        {

            PasswordType[] types = new[]{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(10, types);
            Assert.AreEqual(10, password.Length);
        }

        [TestMethod]
        public void _１２文字のPassword生成()
        {

            PasswordType[] types = new[]{
                PasswordType.Alphabet,
                PasswordType.Number
            };
            string password = PasswordGeneratorHelper.Create(12, types);
            Assert.AreEqual(12, password.Length);
        }




    }
}
