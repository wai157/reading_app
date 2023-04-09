using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AccountManager
    {
        private readonly AccountRepository _repository;
        
        public AccountManager(AccountRepository repository)
        {
            _repository = repository;
        }

        public Account Validate(String username, String password)
        {
            foreach(Account account in _repository.GetAllAccounts())
            {
                if (account.Username == username && account.Password == password)
                    return account;
            }
            return null;
        }
    }
}
