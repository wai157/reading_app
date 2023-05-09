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
        
        public List<GenreDTO> GetAllGenres()
        {
            List<Genre> genres =  _context.Genres.ToList();
            List<GenreDTO> genreDTOs = new List<GenreDTO>();
            foreach(Genre genre in genres)
            {
                GenreDTO genreDTO = Mapper.ToGenreDTO(genre);
                genreDTOs.Add(genreDTO);
            }
            return genreDTOs;
        }

        public GenreDTO GetGenreById(int Id)
        {
            Genre genre = _context.Genres.FirstOrDefault(x => x.Id == Id);
            return Mapper.ToGenreDTO(genre); 
        }
    }
}
