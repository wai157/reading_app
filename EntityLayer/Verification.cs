using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Verification
    {
        [ForeignKey("Account")]
        public int Id { get; set; }
        public int Code { get; set; }
        public DateTime RequestedDateTime { get; set; }

        public virtual Account Account { get; set; }
    }
}
