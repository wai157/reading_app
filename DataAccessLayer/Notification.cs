using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Notification
    {
        public int CreateAccountID { get; set; }
        public int ReceiverRoleID { get; set; }
        public int ReceiverAccountID { get; set; }
        public string Content { get; set; }
    }
}
