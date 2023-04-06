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

        public List<Account> GetAllAccounts()
        {
            return _repository.GetAllAccounts();
        }
    }
}
