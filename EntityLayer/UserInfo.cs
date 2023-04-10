using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DOB { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
