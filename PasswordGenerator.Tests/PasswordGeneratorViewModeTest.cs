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
            _viewModel.Create();


            Assert.AreEqual(10, _viewModel.PasswordText.Length);


            var _viewModel2 = new PasswordGeneratorViewModel();
            // パスワードの種類を選ぶ
            _viewModel2.AlphabetCheck = true;
            _viewModel2.NumberCheck = true;

            // パスワードの文字数を選ぶ
            _viewModel2.PasswordLength = 8;

            // パスワード生成を押す
            _viewModel2.Create();
            Assert.AreEqual(8, _viewModel2.PasswordText.Length);
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



        [TestMethod]
        public void パスワードの長さを一つも選択しなかった場合の例外処理()
        {
            Assert.AreEqual(10, 10);


            var _viewModel = new PasswordGeneratorViewModel();

            // パスワードの種類を選ぶ
            _viewModel.AlphabetCheck = true;
            _viewModel.NumberCheck = false;

            // パスワード生成を押す
            var ex = AssertEx.Throws<InputException>(() => _viewModel.Create());
            ex.Message.Is("パスワードの長さが選択されていません");
        }


    }
}