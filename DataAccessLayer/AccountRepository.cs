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
        public int IsExistByUsername(string username)
        {
            try 
            {
                Account account = _context.Accounts.First(x => x.Username == username);
                return account.Id;
            }
            catch (InvalidOperationException e)
            {
                return -1;
            }
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
                Id = IsExistByUsername(registerAccount.Username),
                Avatar = Extensions.ImageToByteArray(Resources._634011),
                DOB = new DateTime(1945, 09, 02)
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
    }
}
