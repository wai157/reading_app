using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class UserInfo
    {
        [ForeignKey("Account")]
        public int Id { get; set; }
        public byte[] Avatar { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }

        public virtual Account Account { get; set; }
    }
}
