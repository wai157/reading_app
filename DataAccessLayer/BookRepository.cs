﻿using DataTransferObjectLayer;
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

        public BookDTO GetBookById(int Id)
        {
            Book book = _context.Books.First(x => x.Id == Id);
            return Mapper.ToBookDTO(book);
        }

        public List<BookDTO> GetBooksUploadById(int accountId)
        {
            List<Book> books = _context.Books.Where(x => x.AccountId == accountId)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetHotBooks()
        {
            List<Book> books = _context.Books.OrderByDescending(x => x.Views)
                                             .ThenByDescending(x => _context.Libraries.Where(s => s.BookId == x.Id).Count())
                                             .ThenByDescending(x => _context.RatedBooks.Where(s => s.BookId == x.Id).Select(s => s.Rating).DefaultIfEmpty().Average())
                                             .Take(6)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach(Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetBooksByGenreId(int genreId)
        {
            List<Book> books = _context.Books.Where(x => x.GenreId == genreId)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetBooksByAuthorId(int authorId)
        {
            List<Book> books = _context.Books.Where(x => x.AuthorId == authorId)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
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
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void AddBook(BookDTO book)
        {
            Author author = _context.Authors.First(x => x.Name == book.Author);
            _context.Books.Add(new Book
            {
                Name = book.Name,
                Description = book.Description,
                Cover = book.BookCover,
                GenreId = book.GenreId,
                AuthorId = author.Id,
                AccountId = book.UploadAccountId
            });
            _context.SaveChanges();
        }

        public void UpdateBook(BookDTO updatedBook)
        {
            Author author = _context.Authors.First(x => x.Name == updatedBook.Author);
            Book book = _context.Books.First(x => x.Id == updatedBook.Id);
            book.Cover = updatedBook.BookCover;
            book.Name = updatedBook.Name;
            book.AuthorId = author.Id;
            book.Description = updatedBook.Description;
            book.GenreId = updatedBook.GenreId;
            _context.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            Book bookToDelete = _context.Books.FirstOrDefault(x => x.Id == Id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }

        public List<BookDTO> GetSearchBooks(string search)
        {
            List<Book> books = _context.Books.Where(x => x.Name.ToLower().Contains(search)).ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void IncreaseView(int Id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == Id);
            book.Views += 1;
            _context.SaveChanges();
        }
    }
}
