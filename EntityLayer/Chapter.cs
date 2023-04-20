using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Chapter
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public int BookId { get; set; }
        
        public virtual Book Book { get; set; }
    }
}
