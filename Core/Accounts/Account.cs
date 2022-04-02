using BetterMC.Core.Exception;

namespace BetterMC.Core.Accounts
{
    public sealed class Account
    {
        private string login, password, accessToken;
        private readonly AccountType type;

        public string Login
        {
            get { return login; }
            set
            {
                if (login.Length == 0) throw new EmptyLoginException("Empty login.");
                login = value;
                // TODO: Validation
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (type == AccountType.CRACKED || type == AccountType.MICROSOFT) throw new InvalidTypeException("Password cannot be set.");
                if (value.Length == 0) throw new EmptyPasswordException("Empty password.");
                password = value;
                // TODO: Validation
            }
        }

        public string AccessToken
        {
            get { return accessToken; }
            set
            {
                if (type != AccountType.MICROSOFT) throw new InvalidTypeException("Access token cannot be set to non-microsoft account.");
                if (value.Length == 0) throw new EmptyTokenException("Empty token");
                accessToken = value;
                // TODO: Validation
            }
        }

        public AccountType Type
        {
            get { return type; }
        }

        public Account(string login, AccountType type)
        {
            switch (type)
            {
                case AccountType.CRACKED:
                    this.Login = login;
                    break;
                case AccountType.MICROSOFT:
                    this.AccessToken = login;
                    break;
                default:
                    throw new InvalidTypeException("Unknown account type.");
            }
            this.type = type;
        }

        public Account(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            this.type = AccountType.MOJANG;
        }

        public void Auth()
        {

        }

        #region operators
        public static bool operator ==(Account a, Account b) => a.GetType() == b.GetType() && a.Login == b.Login && a.Password == b.Password;
        public static bool operator !=(Account a, Account b) => a.GetType() != b.GetType() || a.Login != b.Login || a.Password != b.Password;
        #endregion
    }
}
