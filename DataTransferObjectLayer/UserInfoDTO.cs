using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }
    }
}
