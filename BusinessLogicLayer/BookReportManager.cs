using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BookReportManager
    {
        private readonly BookReportRepository _bookReportRepository;

        public BookReportManager()
        {
            _bookReportRepository = new BookReportRepository();
        }

        public void AddBookReport(int accountId, int bookId, string content)
        {
            _bookReportRepository.AddBookReport(new BookReportDTO
            {
                CreateAccountID = accountId,
                ReportedBookID = bookId,
                Content = content
            });
        }

        public BookReportDTO GetBookReportById(int id)
        {
            return _bookReportRepository.GetBookReportById(id);
        }

        public List<BookReportDTO> GetAllBookReports()
        {
            return _bookReportRepository.GetAllBookReports();
        }

        public void DeleteBookReport(int id)
        {
            _bookReportRepository.DeleteBookReport(id);
        }
    }
}
