using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class VerificationDTO
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public DateTime RequestedDateTime { get; set; }
    }
}
