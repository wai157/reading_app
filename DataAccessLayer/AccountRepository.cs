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

        public List<AccountDTO> GetAllAccounts()
        {
            List<Account> accounts = _context.Accounts.ToList();
            List<AccountDTO> accountDTOs = new List<AccountDTO>();
            foreach(Account account in accounts)
            {
                AccountDTO accountDTO = new AccountDTO();
                accountDTO.Id = account.Id;
                accountDTO.Username = account.Username;
                accountDTO.Email = account.Email;
                accountDTO.Password = account.Password;
                accountDTO.RoleID = account.RoleId;
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
                userInfoDTO.Name = userInfo.Name;
                userInfoDTO.Sex = userInfo.Sex;
                userInfoDTO.DOB = userInfo.DOB;
            }
            return userInfoDTO;
        }
    }
}
