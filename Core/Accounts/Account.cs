namespace BetterMC.Core.Accounts
{
    abstract class Account
    {
        public string login { get; set; }
        public string password { get; set; }
        public string accessToken { get; set; }
        public AccountType type { get; }

        public Account(string login, AccountType type, string password = "", string accessToken = "")
        {
            this.login = login;
            this.password = password;
            this.type = type;
            this.accessToken = accessToken;
        }
    }
}
