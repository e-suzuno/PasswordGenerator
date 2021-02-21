using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Domain.ValueObjects
{
    public class PasswordType : ValueObject<PasswordType>
    {
        public const int Alphabet = 1;
        public const int Number = 2;


        public int Value { get; }


        public PasswordType(int value)
        {
            Value = value;
        }

        


        protected override bool EqualsCore(PasswordType other)
        {
            return Value == other.Value;
        }

    }
}