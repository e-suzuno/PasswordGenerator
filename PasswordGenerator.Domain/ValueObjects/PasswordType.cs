using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Domain.ValueObjects
{
    public class PasswordType : ValueObject<PasswordType>
    {
        public const int AlphabetValue = 1;
        public const int NumberValue = 2;


        public static PasswordType Alphabet = new PasswordType(AlphabetValue);
        public static PasswordType Number = new PasswordType(NumberValue);


        public int Value { get; }


        public PasswordType(int value)
        {
            Value = value;
        }

        protected override bool EqualsCore(PasswordType other)
        {
            return Value == other.Value;
        }



        public static IList<PasswordType> ToList()
        {
            return new List<PasswordType> {
                Alphabet,
                Number
            };
        }


    }
}