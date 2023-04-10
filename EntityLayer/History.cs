using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class History
    {
        public int Id { get; set; }
        public string ReadChapterIds { get; set; }

        public int AccountId { get; set; }
        public int BookId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Book Book { get; set; }
    }
}
