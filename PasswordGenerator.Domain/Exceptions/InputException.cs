﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Domain.Exceptions
{
    public sealed class InputException : Exception
    {

        public InputException(string massage) : base(massage)
        {

        }
    }

}
