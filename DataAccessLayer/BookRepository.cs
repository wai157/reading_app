using DataTransferObjectLayer;
using EntityLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookRepository
    {
        private readonly PBL3DbContext _context;

        public BookRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<BookDTO> GetHotBooks()
        {
            List<Book> books = _context.Books.ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach(Book book in books)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Name = book.Name;
                bookDTO.BookCover = book.Cover;
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }
    }
}
