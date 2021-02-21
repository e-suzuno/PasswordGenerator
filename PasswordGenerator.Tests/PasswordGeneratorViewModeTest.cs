using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Forms.ViewModels;
using System;
using PasswordGenerator.Domain.Exceptions;

namespace PasswordGenerator.Tests
{
    [TestClass]
    public class PasswordGeneratorViewModeTest
    {
        [TestMethod]
        public void パスワード生成シナリオ()
        {
            var _viewModel = new PasswordGeneratorViewModel();


            // パスワードの種類を選ぶ
            _viewModel.AlphabetCheck = true;
            _viewModel.NumberCheck = true;

            // パスワードの文字数を選ぶ
            _viewModel.PasswordLength = 10;

            // パスワード生成を押す
            string PasswordText = _viewModel.Create();


            Assert.AreEqual(10, PasswordText.Length);


            // パスワードの種類を選ぶ
            _viewModel.AlphabetCheck = true;
            _viewModel.NumberCheck = true;

            // パスワードの文字数を選ぶ
            _viewModel.PasswordLength = 8;

            // パスワード生成を押す
            string PasswordTex2t = _viewModel.Create();
            Assert.AreEqual(8, PasswordTex2t.Length);
        }


        [TestMethod]
        public void パスワードタイプを一つも選択しなかった場合の例外処理()
        {
            var _viewModel = new PasswordGeneratorViewModel();


            // パスワードの種類を選ぶ
            _viewModel.AlphabetCheck = false;
            _viewModel.NumberCheck = false;

            // パスワードの文字数を選ぶ
            _viewModel.PasswordLength = 8;


            // パスワード生成を押す
            var ex = AssertEx.Throws<InputException>(() => _viewModel.Create());
            ex.Message.Is("パスワードタイプが選択されていません");
        }
    }
}