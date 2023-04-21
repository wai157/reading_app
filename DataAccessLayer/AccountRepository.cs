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
            AccountDTO accountDTO = new AccountDTO
            {
                Id = account.Id,
                Username = account.Username,
                Email = account.Email,
                Password = account.Password,
                RoleID = account.RoleId
            };
            return accountDTO;
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
                AccountDTO accountDTO = new AccountDTO
                {
                    Id = account.Id,
                    Username = account.Username,
                    Email = account.Email,
                    Password = account.Password,
                    RoleID = account.RoleId
                };
                accountDTOs.Add(accountDTO);
            }
            return accountDTOs;
        }

        public UserInfoDTO GetUserInfo(int accountId)
        {
            UserInfo userInfo = _context.UserInfoes.Find(accountId);
            UserInfoDTO userInfoDTO = new UserInfoDTO();
            if (userInfo != null)
            {
                userInfoDTO.Id = userInfo.Id;
                userInfoDTO.Name = userInfo.Name;
                userInfoDTO.Avatar = userInfo.Avatar;
                userInfoDTO.Sex = userInfo.Sex;
                userInfoDTO.DOB = userInfo.DOB;
            }
            return userInfoDTO;
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
    }
}
