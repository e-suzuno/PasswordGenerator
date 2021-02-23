using System;
using System.Collections.Generic;
using PasswordGenerator.Domain.Helpers;
using System.Diagnostics;
using PasswordGenerator.Domain.Exceptions;
using PasswordGenerator.Domain.ValueObjects;

namespace PasswordGenerator.Forms.ViewModels
{
    public class PasswordGeneratorViewModel : ViewModelBase
    {
        private bool _AlphabetCheck;

        public bool AlphabetCheck
        {
            get => _AlphabetCheck;
            set => SetProperty(ref _AlphabetCheck, value);
        }


        private bool _NumberCheck;

        public bool NumberCheck
        {
            get => _NumberCheck;
            set => SetProperty(ref _NumberCheck, value);
        }


        private int _PasswordLength = 0;

        public int PasswordLength
        {
            get => _PasswordLength;
            set => SetProperty(ref _PasswordLength, value);
        }


        private string _PasswordText = String.Empty;

        public string PasswordText
        {
            get => _PasswordText;
            set => SetProperty(ref _PasswordText, value);
        }


        public void Create()
        {
            List<PasswordType> PasswordTypes = new List<PasswordType>();

            if (AlphabetCheck)
            {
                PasswordTypes.Add(PasswordType.Alphabet);
            }

            if (NumberCheck)
            {
                PasswordTypes.Add(PasswordType.Number);
            }



            if (PasswordLength == 0)
            {
                throw new InputException("パスワードの長さが選択されていません");
            }
            if (PasswordTypes.Count < 1)
            {
                throw new InputException("パスワードタイプが選択されていません");
            }

            PasswordText = PasswordGeneratorHelper.Create(PasswordLength, PasswordTypes.ToArray());
        }
    }
}