using DataAccessLayer;
using DataTransferObjectLayer;
using Common;
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
        
        public AccountManager()
        {
            _repository = new AccountRepository();
        }

        public AccountDTO Validate(String username, String password)
        {
            foreach(AccountDTO account in _repository.GetAllAccounts())
            {
                if (account.Username == username && account.Password == Extensions.GetSHA256Hash(password))
                    return account;
            }
            return null;
        }

        public UserInfoDTO GetUserInfo(int accountId)
        {
            return _repository.GetUserInfo(accountId);
        }
    }
}
