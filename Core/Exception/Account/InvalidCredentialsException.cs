using System;

namespace BetterMC.Core.Exception
{
    abstract class InvalidCredentialsException : ArgumentException
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }

    sealed class EmptyLoginException : InvalidCredentialsException
    {
        public EmptyLoginException(string message) : base(message) { }
    }

    sealed class InvalidLoginException : InvalidCredentialsException
    {
        public InvalidLoginException(string message) : base(message) { }
    }

    sealed class EmptyPasswordException : InvalidCredentialsException
    {
        public EmptyPasswordException(string message) : base(message) { }
    }

    sealed class InvalidPasswordException : InvalidCredentialsException
    {
        public InvalidPasswordException(string message) : base(message) { }
    }

    sealed class InvalidTypeException : InvalidCredentialsException
    {
        public InvalidTypeException(string message) : base(message) { }
    }
    
    sealed class EmptyTokenException : InvalidCredentialsException
    {
        public EmptyTokenException(string message) : base(message) { }
    }
}
