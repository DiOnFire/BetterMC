using System;

namespace BetterMC.Core.Exception
{
    sealed class InvalidInstallationTypeException : InvalidOperationException
    {
        public InvalidInstallationTypeException(string message) : base(message) { }
    }
}
