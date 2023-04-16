using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
        public int Rating { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public int AccountId { get; set; }
        public int AuthorId { get; set; }

        public virtual List<BookGenre> BookGenre { get; set; }
        public virtual List<Chapter> Chapters { get; set; }
        public virtual Account UploadAccount { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<History> Histories { get; set; }
        public virtual List<Library> Libraries { get; set; }
        public virtual List<RatedBook> RatedBooks { get; set; }
    }
}
