using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Book
    {
        public string Name { get; set; }
        public List<string> Genres { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public List<Chapter> Chapters { get; set; }
        public string UploadAccount { get; set; }
        public string Author { get; set; }
    }
}
