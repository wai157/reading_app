using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class RatedBookDTO
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; }
    }
}
