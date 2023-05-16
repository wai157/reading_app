using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class NotificationDTO
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public int BookID { get; set; }
        public string Content { get; set; }
    }
}
