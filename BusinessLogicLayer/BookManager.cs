﻿using DataAccessLayer;
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
        private readonly BookRepository _bookRepository;
        private readonly AuthorRepository _authorRepository;

        public BookManager()
        {
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
        }

        public BookDTO GetBookById(int Id)
        {
            return _bookRepository.GetBookById(Id);
        }

        public List<BookDTO> GetBooksUploadById(int accountId)
        {
            return _bookRepository.GetBooksUploadById(accountId);
        }

        public List<BookDTO> GetHotBooks()
        {
            return _bookRepository.GetHotBooks();
        }

        public List<BookDTO> GetBooksByGenreId(int genreId)
        {
            return _bookRepository.GetVerifiedBooksByGenreId(genreId);
        }

        public List<BookDTO> GetBooksByAuthorName(string name)
        {
            int authorId = _authorRepository.GetAuthorByName(name).Id;
            return _bookRepository.GetVerifiedBooksByAuthorId(authorId);
        }

        public List<BookDTO> GetAllVerifiedBooks()
        {
            return _bookRepository.GetAllVerifiedBooks();
        }

        public List<BookDTO> GetAllUnverifiedBooks()
        {
            return _bookRepository.GetAllUnverifiedBooks();
        }

        public void AddBook(BookDTO book)
        {
            if (_authorRepository.GetAuthorByName(book.Author) == null)
            {
                _authorRepository.AddAuthor(book.Author);
            }
            _bookRepository.AddBook(book);
        }

        public void UpdateBook(BookDTO updatedBook)
        {
            if( _authorRepository.GetAuthorByName(updatedBook.Author) == null)
            {
                _authorRepository.AddAuthor(updatedBook.Author);
            }
            _bookRepository.UpdateBook(updatedBook);
        }

        public void VerifyBook(int bookId)
        {
            _bookRepository.VerifyBook(bookId);
        }

        public void VerifyAllBooks()
        {
            foreach(BookDTO book in _bookRepository.GetAllUnverifiedBooks())
            {
                _bookRepository.VerifyBook(book.Id);
            }
        }

        public void DeleteBook(int Id)
        {
            _bookRepository.DeleteBook(Id);
        }

        public List<BookDTO> GetSearchBooks(string search)
        {
            return _bookRepository.GetSearchBooks(search.ToLower().Trim());
        }

        public void IncreaseView(int Id)
        {
            _bookRepository.IncreaseView(Id);
        }
    }
}
