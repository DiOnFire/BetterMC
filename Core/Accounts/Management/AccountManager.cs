using BetterMC.Core.Files;
using System.Collections.Generic;

namespace BetterMC.Core.Accounts.Management
{
    sealed class AccountManager
    {
        private List<Account> accounts = new List<Account>();

        public void Load()
        {
            AccountLoader loader = new AccountLoader();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            accounts.Remove(account);
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }
    }
}
