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

        public AccountDTO GetAccountByUsername(string username)
        {
            return _repository.GetAccountByUsername(username);
        }

        public void DeleteAccount(int Id)
        {
            _repository.DeleteAccount(Id);
        }

        public bool ChangePassword(int Id, string oldPass, string newPass)
        {
            if (_repository.GetAccountById(Id).Password != Extensions.GetSHA256Hash(oldPass))
            {
                return false;
            }
            _repository.ChangePassword(Id, Extensions.GetSHA256Hash(newPass));
            return true;
        }

        public bool SendCode(string username)
        {
            AccountDTO account = _repository.GetAccountByUsername(username);
            if (account != null)
            {
                string address = account.Email;
                EmailService emailService = new EmailService();
                int code = emailService.SendEmail(address);
                DateTime requestedDateTime = DateTime.Now;
                _repository.UpdateVerification(new VerificationDTO
                {
                    Id = account.Id,
                    Code = code,
                    RequestedDateTime = requestedDateTime
                });
                return true;
            }
            return false;
        }

        public bool VerifyCode(string username, string code)
        {
            AccountDTO account = _repository.GetAccountByUsername(username);
            VerificationDTO verification = _repository.GetVerification(account.Id);
            TimeSpan diff = DateTime.Now - verification.RequestedDateTime;
            if (verification.Code.ToString() == code && diff.TotalMinutes <= 30)
            {
                return true;
            }
            return false;
        }

        public void ResetPassword(int Id, string newPass)
        {
            _repository.ChangePassword(Id, Extensions.GetSHA256Hash(newPass));
        }
    }
}
