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
                accountDTO.Username = account.Username;
                accountDTO.Password = account.Password;
                accountDTOs.Add(accountDTO);
            }
            return accountDTOs;
        }
    }
}
