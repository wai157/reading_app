using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GenreRepository
    {
        private readonly PBL3DbContext _context;

        public GenreRepository()
        {
            _context = new PBL3DbContext();
        }
        
        public List<string> GetAllGenres()
        {
            return _context.Genres.Select(x => x.Name).ToList();
        }
    }
}
