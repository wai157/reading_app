using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class HistoryDTO
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BookId { get; set; }
        public List<int> ReadChapterIds { get; set; }
    }
}
