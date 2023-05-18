using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Notification
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BookId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual Account Account { get; set; }
    }
}
