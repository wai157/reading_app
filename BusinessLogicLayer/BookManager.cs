using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BookManager
    {
        private readonly BookRepository _repository;

        public BookManager(BookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetHotBooks()
        {
            return _repository.GetHotBooks();
        }
    }
}
