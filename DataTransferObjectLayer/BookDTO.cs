using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] BookCover { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
        public int Rating { get; set; }
        public int Views { get; set; }
        public int Follows { get; set; }
        public int UploadAccountId { get; set; }
        public string Author { get; set; }
    }
}
