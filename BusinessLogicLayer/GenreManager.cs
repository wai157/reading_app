using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GenreManager
    {
        private readonly GenreRepository _repository;

        public GenreManager()
        {
            _repository = new GenreRepository();
        }

        public List<GenreDTO> GetAllGenres()
        {
            return _repository.GetAllGenres();
        }

        public GenreDTO GetGenreById(int Id)
        {
            return _repository.GetGenreById(Id);
        }
    }
}
