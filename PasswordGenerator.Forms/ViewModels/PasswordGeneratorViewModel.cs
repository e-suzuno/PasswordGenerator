using System;
using System.Collections.Generic;
using PasswordGenerator.Domain.Helpers;
using System.Diagnostics;
using PasswordGenerator.Domain.Exceptions;
using PasswordGenerator.Domain.ValueObjects;

namespace PasswordGenerator.Forms.ViewModels
{
    public class PasswordGeneratorViewModel
    {
        public bool length8Checked { get; set; } = true;
        public bool length10Checked { get; set; } = false;
        public bool length12Checked { get; set; } = false;

        public bool AlphabetCheck { get; set; } = true;
        public bool NumberCheck { get; set; } = false;


        public string PasswordText { get; set; }
        public int PasswordLength { get; set; }

        public string Create()
        {
            List<int> PasswordTypes = new List<int>();

            if (AlphabetCheck)
            {
                PasswordTypes.Add(PasswordType.Alphabet);
            }

            if (NumberCheck)
            {
                PasswordTypes.Add(PasswordType.Number);
            }


            if (PasswordTypes.Count < 1)
            {
                throw new InputException("パスワードタイプが選択されていません");
            }


            return PasswordGeneratorHelper.Create(PasswordLength, PasswordTypes.ToArray());
        }
    }
}