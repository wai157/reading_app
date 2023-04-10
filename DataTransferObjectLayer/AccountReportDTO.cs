using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    class AccountReportDTO
    {
        public int CreateAccountID { get; set; }
        public int ReportedAccountID { get; set; }
        public string Content { get; set; }
    }
}
