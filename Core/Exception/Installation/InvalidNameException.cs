using System;

namespace BetterMC.Core.Exception
{
    sealed class InvalidNameException : ArgumentException
    {
        public InvalidNameException(string message) : base(message) { }
    }
}
