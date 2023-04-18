using DataAccessLayer;
using DataTransferObjectLayer;
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

        public BookManager()
        {
            _repository = new BookRepository();
        }

        public List<BookDTO> GetHotBooks()
        {
            return _repository.GetHotBooks();
        }

        public List<BookDTO> GetAllBooks()
        {
            return _repository.GetAllBooks();
        }
        public void AddBook(BookDTO book)
        {
            _repository.AddBook(book);
        }
    }
}
