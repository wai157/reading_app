using Common;
using DataAccessLayer.Properties;
using DataTransferObjectLayer;
using EntityLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountRepository
    {
        private readonly PBL3DbContext _context;

        public AccountRepository()
        {
            _context = new PBL3DbContext();
        }

        public AccountDTO GetAccountById(int Id)
        {
            Account account = _context.Accounts.First(x => x.Id == Id);
            return Mapper.ToAccountDTO(account);
        }
        public AccountDTO GetAccountByUsername(string username)
        {
            return Mapper.ToAccountDTO(_context.Accounts.FirstOrDefault(x => x.Username == username));
        }

        public void AddAccount(AccountDTO registerAccount)
        {
            _context.Accounts.Add(new Account
            {
                Email = registerAccount.Email,
                Username = registerAccount.Username,
                Password = registerAccount.Password,
                RoleId = 3
            });
            _context.SaveChanges();
            _context.UserInfoes.Add(new UserInfo
            {
                Id = GetAccountByUsername(registerAccount.Username).Id,
                Avatar = Extensions.ImageToByteArray(Resources._634011),
                DOB = new DateTime(1945, 09, 02)
            });
            _context.Verifications.Add(new Verification
            {
                Id = GetAccountByUsername(registerAccount.Username).Id
            });
            _context.SaveChanges();
        }

        public List<AccountDTO> GetAllAccounts()
        {
            List<Account> accounts = _context.Accounts.ToList();
            List<AccountDTO> accountDTOs = new List<AccountDTO>();
            foreach(Account account in accounts)
            {
                AccountDTO accountDTO = Mapper.ToAccountDTO(account);
                accountDTOs.Add(accountDTO);
            }
            return accountDTOs;
        }

        public void DeleteAccount(int Id)
        {
            Account accountToDelete = _context.Accounts.FirstOrDefault(x => x.Id == Id);
            if(accountToDelete != null)
            {
                _context.Accounts.Remove(accountToDelete);
                _context.SaveChanges();
            }
        }

        public void ChangePassword(int Id, string newPass)
        {
            Account account = _context.Accounts.FirstOrDefault(x => x.Id == Id);
            if (account != null)
            {
                account.Password = newPass;
                _context.SaveChanges();
            }
        }

        public UserInfoDTO GetUserInfo(int accountId)
        {
            UserInfo userInfo = _context.UserInfoes.First(x => x.Id == accountId);
            return Mapper.ToUserInfoDTO(userInfo);
        }

        public void UpdateUserInfo(AccountDTO updatedAccount, UserInfoDTO updatedUserInfo)
        {
            UserInfo userInfo = _context.UserInfoes.First(x => x.Id == updatedUserInfo.Id);
            Account account = _context.Accounts.First(x => x.Id == updatedAccount.Id);
            userInfo.Name = updatedUserInfo.Name;
            userInfo.Avatar = updatedUserInfo.Avatar;
            userInfo.Sex = updatedUserInfo.Sex;
            userInfo.DOB = updatedUserInfo.DOB;
            account.RoleId = updatedAccount.RoleID;
            _context.SaveChanges();
        }

        public VerificationDTO GetVerification(int accountId)
        {
            Verification verification = _context.Verifications.First(x => x.Id == accountId);
            return Mapper.ToVerificationDTO(verification);
        }

        public void UpdateVerification(VerificationDTO updatedVerification)
        {
            Verification verification = _context.Verifications.First(x => x.Id == updatedVerification.Id);
            verification.Code = updatedVerification.Code;
            verification.RequestedDateTime = updatedVerification.RequestedDateTime;
            _context.SaveChanges();
        }
    }
}
