using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public enum Sex
    {
        Male,
        Female,
        Other
    }

    public class AccountDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public Sex Sex { get; set; }
        public DateTime DOB { get; set; }
        public List<int> FollowedBookIDs { get; set; }
        public Dictionary<int, List<int>> History { get; set; }
    }
}
