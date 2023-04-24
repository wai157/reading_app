using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LibraryManager
    {
        private readonly LibraryRepository _libraryRepository;
        
        public LibraryManager()
        {
            _libraryRepository = new LibraryRepository();
        }
        public List<LibraryDTO> GetLibraryByAccountId(int accountId)
        {
            return _libraryRepository.GetLibraryByAccountId(accountId);
        }
        public void AddLibrary(int accountId, int bookId)
        {
            _libraryRepository.AddLibrary(new LibraryDTO
            {
                AccountId = accountId,
                BookId = bookId
            });
        }
        public void DeleteLibrary(int Id)
        {
            _libraryRepository.DeleteLibrary(Id);
        }
    }
}
