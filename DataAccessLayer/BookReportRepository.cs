using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookReportRepository
    {
        private readonly PBL3DbContext _context;

        public BookReportRepository()
        {
            _context = new PBL3DbContext();
        }
        public void AddBookReport(BookReportDTO bookReportDTO)
        {
            _context.BookReports.Add(new BookReport
            {
                AccountID = bookReportDTO.CreateAccountID,
                BookID = bookReportDTO.ReportedBookID,
                Content = bookReportDTO.Content
            });
            _context.SaveChanges();
        }

        public BookReportDTO GetBookReportById(int id)
        {
            return Mapper.ToBookReportDTO(_context.BookReports.FirstOrDefault(x => x.Id == id));
        }

        public List<BookReportDTO> GetAllBookReports()
        {
            List<BookReport> bookReports = _context.BookReports.ToList();
            List<BookReportDTO> bookReportDTOs = new List<BookReportDTO>();
            foreach (BookReport bookReport in bookReports)
            {
                BookReportDTO bookReportDTO = Mapper.ToBookReportDTO(bookReport);
                bookReportDTOs.Add(bookReportDTO);
            }
            return bookReportDTOs;
        }

        public void DeleteBookReport(int id)
        {
            BookReport bookReport = _context.BookReports.FirstOrDefault(x => x.Id == id);
            if (bookReport != null)
            {
                _context.BookReports.Remove(bookReport);
                _context.SaveChanges();
            }
        }
    }
}
