using DataAccessLayer;
using DataTransferObjectLayer;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AccountManager
    {
        private readonly AccountRepository _repository;
        
        public AccountManager()
        {
            _repository = new AccountRepository();
        }

        public AccountDTO GetAccountById(int Id)
        {
            return _repository.GetAccountById(Id);
        }

        public List<AccountDTO> GetAllAccounts()
        {
            return _repository.GetAllAccounts();
        }

        public void AddAccount(AccountDTO registerAccount)
        {
            registerAccount.Password = Extensions.GetSHA256Hash(registerAccount.Password);
            _repository.AddAccount(registerAccount);
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

        public void UpdateUserInfo(AccountDTO updatedAccount, UserInfoDTO updatedUserInfo)
        {
            _repository.UpdateUserInfo(updatedAccount, updatedUserInfo);
        }

        public bool IsUsernameExist(string username)
        {
            if(_repository.IsExistByUsername(username) == -1)
            {
                return false;
            }
            return true;
        }

        public void DeleteAccount(int Id)
        {
            _repository.DeleteAccount(Id);
        }
    }
}
