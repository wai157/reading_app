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
            List<Book> books = _context.Books.OrderByDescending(x => x.Views)
                                             .ThenByDescending(x => x.Likes)
                                             .ThenByDescending(x => x.Rating)
                                             .Take(6)
                                             .ToList();
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

        public List<BookDTO> GetAllBooks()
        {
            List<Book> books = _context.Books.ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Name = book.Name;
                bookDTO.BookCover = book.Cover;
                bookDTO.Author = _context.Authors.First(x => x.Id == book.AuthorId).Name;
                bookDTO.UploadAccountId = book.AccountId;
                bookDTO.Description = book.Description;
                bookDTO.Genre = _context.Genres.First(x => x.Id == book.GenreId).Name;
                bookDTO.Follows = _context.Libraries.Where(x => x.BookId == book.Id).Count();
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void AddBook(BookDTO book)
        {
            if(_context.Authors.Where(x => x.Name == book.Author).Count() == 0)
            {
                _context.Authors.Add(new Author { Name = book.Author });
                _context.SaveChanges();
            }
            Author author = _context.Authors.First(x => x.Name == book.Author);
            Genre genre = _context.Genres.First(x => x.Name == book.Genre);
            _context.Books.Add(new Book
            {
                Name = book.Name,
                Description = book.Description,
                Cover = book.BookCover,
                GenreId = genre.Id,
                AuthorId = author.Id,
                AccountId = book.UploadAccountId
            });
            _context.SaveChanges();
        }
    }
}
