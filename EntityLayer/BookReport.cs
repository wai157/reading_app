using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BookReport
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public int BookID { get; set; }
        public string Content { get; set; }

        public virtual Account Account { get; set; }
        public virtual Book Book { get; set; }
    }
}
