using BetterMC.Core.Files;
using System.Collections.Generic;

namespace BetterMC.Core.Accounts.Management
{
    sealed class AccountManager
    {
        #region fields
        private List<Account> accounts;

        public List<Account> Accounts
        {
            get { return accounts; }
        }
        #endregion

        public AccountManager() => accounts = new List<Account>();

        #region methods
        public void AddAccount(Account account) => accounts.Add(account);

        public void DeleteAccount(Account account) => accounts.Remove(account);
        #endregion
    }
}
